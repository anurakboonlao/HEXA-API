using System;
namespace HexaOnlineOrdering.Api.Utils
{
    public class QueryConditional
    {
        public string FieldName { get; set; }
        public OperatorType Operator { get; set; }
        public dynamic Value { get; set; }
    }


    public enum OperatorType
    {
        EQUAL,
        NOT_EQUAL,
        GREATER_THAN,
        GREATER_OR_EQUAL,
        LESS_THAN,
        LESS_OR_EQUAL,
        IN,
        NOT_IN,
        LIKE_SENSITIVE,
        LIKE_INSENSITIVE
    }
}
