using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace HexaOnlineOrdering.Api.Extensions
{
    public interface IMappable { }

    public static class MappingExtensions
    {
        /// <summary>
        /// Get an object of type 'toType', created from the current object.
        /// </summary>
        /// <typeparam name="toType"></typeparam>
        /// <param name="from"></param>
        /// <returns>The mapped object</returns>
        public static toType MapTo<toType>(this object from, int maxLevel = 3)
        {
            if (from == null) return default;
            //var newTo = new toType();
            var newTo = Activator.CreateInstance(typeof(toType));
            return (toType)from.MapRecursive(newTo, 0, maxLevel);
        }

        /// <summary>
        ///  Get object list of type 'toType', created from the current object list.
        /// </summary>
        /// <typeparam name="toType"></typeparam>
        /// <param name="from"></param>
        /// <returns>The mapped object list</returns>
        public static List<toType> MapToList<toType>(this IEnumerable<object> from, int maxLevel = 1)
        {
            return from?.Select(r => r.MapTo<toType>(maxLevel))?.ToList();
        }

        /// <summary>
        /// Get an object of type 'toType' created from the to object and replacing the properties matched in from.
        /// This will also update the 'to' object's properties.
        /// </summary>
        /// <typeparam name="toType">The type to map to</typeparam>
        /// <param name="from">The object to map from</param>
        /// <param name="to">The object to use for mapping</param>
        /// <returns>The mapped object</returns>
        public static toType MapTo<toType>(this object from, object to)
        {
            if (from == null) return default;
            return (toType)from.MapRecursive(to);
        }

        /// <summary>
        /// Get an object of type 'toType' created from the to object and replacing the properties matched in from.
        /// This will also update the 'to' object's properties.
        /// </summary>
        /// <typeparam name="toType">The type to map to</typeparam>
        /// <param name="from">The object to map from</param>
        /// <param name="to">The object to use for mapping</param>
        /// <param name="initalizer">Action to invoke, to set extra properties upon the returned object</param>
        /// <returns>The mapped object</returns>
        public static toType MapTo<toType>(this object from, object to, Action<toType> initalizer)
        {
            if (from == null) return default;
            var newTo = (toType)from.MapRecursive(to);
            initalizer(newTo);
            return newTo;
        }

        /// <summary>
        /// Get an object of type 'toType' created from the current object and set properties on the return object in the action.
        /// </summary>
        /// <typeparam name="toType">The type to map to</typeparam>
        /// <param name="from">The object to map from</param>
        /// <param name="initalizer">Action to invoke, to set extra properties upon the returned object</param>
        /// <returns>The mapped object</returns>
        public static toType MapTo<toType>(this object from, Action<toType> initalizer)
        {
            if (from == null) return default;
            //var newTo = new toType();
            var newTo = (toType)Activator.CreateInstance(typeof(toType));
            newTo = (toType)from.MapRecursive(newTo);
            initalizer(newTo);
            return newTo;
        }

        /// <summary>
        /// Get an object of type 'toType' created from the current object of type 'fromType' and set properties on the return object in the action.
        /// </summary>
        /// <typeparam name="fromType"></typeparam>
        /// <typeparam name="toType"></typeparam>
        /// <param name="from"></param>
        /// <param name="initalizer"></param>
        /// <returns>The mapped object</returns>
        public static toType MapTo<fromType, toType>(this object from, Action<fromType, toType> initalizer)
        {
            if (from == null) return default;
            //var newTo = new toType();
            var newTo = (toType)Activator.CreateInstance(typeof(toType));
            newTo = (toType)from.MapRecursive(newTo);
            initalizer((fromType)from, newTo);
            return newTo;
        }
        private static object MapRecursive(this object from, object newTo, int level = 0, int maxLevel = 3)
        {
            if (maxLevel <= 0) maxLevel = 1;
            if (from == null) return default;
            if (level >= maxLevel) return default;
            level++;

            var flags = BindingFlags.Public | BindingFlags.Instance;
            PropertyInfo[] fromProps = from.GetType()?.GetProperties(flags)
                .Where(f => f.CanRead).ToArray();
            if (fromProps == null) return null;
            PropertyInfo toProp = null;

            foreach (var fromProp in fromProps)
            {
                // Compare property name
                //toProp = newTo?.GetType().GetProperty(fromProp.Name, flags);
                toProp = newTo?.GetType().GetProperties(flags)
                    .FirstOrDefault(p => p.Name.ToLower() == fromProp.Name.ToLower());
                // Match property name
                if (toProp != null && toProp.CanWrite)
                {
                    try
                    {
                        // Same name and type
                        if (fromProp.PropertyType == toProp.PropertyType)
                        {
                            var fromValue = fromProp.GetValue(from);
                            toProp.SetValue(newTo, fromValue);
                        }
                        // Same name but different complex types(IEnumerable)
                        else if (fromProp.GetValue(from)?.GetType()?.ImplementsGenericInterface(typeof(IEnumerable<>)) == true
                            && toProp.GetValue(newTo)?.GetType()?.ImplementsGenericInterface(typeof(IEnumerable<>)) == true)
                        {
                            var fromList = (fromProp.GetValue(from) as IEnumerable<object>)?.ToList();
                            if (fromList?.Any() == true)
                            {
                                Type toType = toProp.GetValue(newTo).GetType().GetGenericArguments()[0];
                                //IList toList = (IList)Activator.CreateInstance((typeof(List<>).MakeGenericType(toType)));
                                IList fromValue = CreateGenericList(toType);
                                if (fromValue == null) break;
                                foreach (var item in fromList.Where(i => i != null))
                                {
                                    object mapObj = item.MapRecursive(Activator.CreateInstance(toType), level, maxLevel);
                                    if (mapObj != null)
                                        fromValue.Add(mapObj);
                                }

                                toProp.SetValue(newTo, fromValue);
                            }
                        }
                        // Same name but different enum types(map enum to int)
                        else if (fromProp.GetValue(from)?.GetType()?.IsEnum == true
                            && (toProp.GetValue(newTo)?.GetType() == typeof(int)
                            || (Nullable.GetUnderlyingType(toProp.PropertyType) != null
                            && Nullable.GetUnderlyingType(toProp.PropertyType).Name == "Int32")))
                        {
                            Enum enumValue = fromProp.GetValue(from) as Enum;
                            toProp.SetValue(newTo, Convert.ToInt32(enumValue));
                        }
                        // Same name but different enum types(map int to enum)
                        else if (toProp.GetValue(newTo)?.GetType()?.IsEnum == true
                            && (fromProp.GetValue(from)?.GetType() == typeof(int)
                            || (Nullable.GetUnderlyingType(fromProp.PropertyType) != null
                            && Nullable.GetUnderlyingType(fromProp.PropertyType).Name == "Int32")))
                        {
                            object fromValue = Enum.ToObject(toProp.GetValue(newTo).GetType(), fromProp.GetValue(from));
                            toProp.SetValue(newTo, fromValue);
                        }
                        // Same name but to property is nullable
                        else if (fromProp.GetValue(from)?.GetType()?.Namespace?.StartsWith("System") == true
                            && Nullable.GetUnderlyingType(toProp.PropertyType) != null)
                        {
                            Type underlying = Nullable.GetUnderlyingType(toProp.PropertyType);
                            object fromValue = Convert.ChangeType(fromProp.GetValue(from), underlying);
                            toProp.SetValue(newTo, fromValue);
                        }
                        // Same name but different system types
                        else if (fromProp.GetValue(from)?.GetType()?.Namespace?.StartsWith("System") == true
                            && toProp.GetValue(newTo)?.GetType()?.Namespace?.StartsWith("System") == true)
                        {
                            object fromValue = Convert.ChangeType(fromProp.GetValue(from), toProp.GetValue(newTo).GetType());
                            toProp.SetValue(newTo, fromValue);
                        }
                        // Same name but different complex types
                        else
                        {
                            object newObj = toProp.GetValue(newTo);
                            if (newObj != null)
                            {
                                toProp.SetValue(newTo, fromProp.GetValue(from).MapRecursive(newObj, level, maxLevel));
                            }
                            else if (fromProp.PropertyType.BaseType?.FullName == "System.Object"
                                && toProp.PropertyType.BaseType?.FullName == "System.Object")
                            {
                                // Different object types
                                Type toType = toProp.PropertyType.Assembly.GetType(toProp.PropertyType.FullName);
                                newObj = Activator.CreateInstance(toType);
                                object fromValue = fromProp.GetValue(from).MapRecursive(newObj, level, maxLevel);
                                toProp.SetValue(newTo, fromValue);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Cannot map data
                        Trace.Write($"{nameof(MapRecursive)} failed!, {ex.Message}");
                    }
                }
            }

            return newTo;
        }

        private static IList CreateGenericList(Type T)
        {
            // Creating the Generic List.
            Type d1 = typeof(List<>);

            // Creating the Type for Generic List.
            Type[] typeArgs = { T };

            // Now combing the List and its type.
            Type makeme = d1.MakeGenericType(typeArgs);

            // Creating the Instance for List.
            return Activator.CreateInstance(makeme) as IList;
        }

        public static bool ImplementsGenericInterface(this Type type, Type interfaceType)
        {
            return type
                .GetTypeInfo()
                .ImplementedInterfaces
                .Any(x => x.GetTypeInfo().IsGenericType && x.GetGenericTypeDefinition() == interfaceType);
        }
    }
}
