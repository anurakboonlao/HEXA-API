using System;
using System.Collections.Generic;
using HexaOnlineOrdering.ERP.Models;
using HexaOnlineOrdering.Models;

namespace HexaOnlineOrdering.Api.Utils
{
    public static class NetforceQueryOperator
    {
        /// <summary>
        /// '=' data equal
        /// '!=' data not equal
        /// '>' data more than
        /// '>=' data more than equal
        /// '<' data lower than
        /// '<=' data lower than equal
        /// 'in' data in array
        /// 'not in' data not in array
        /// 'like' data contains (sensitive case)
        /// 'ilike' data contains not (insensitive case)
        /// </summary>
        public static Dictionary<OperatorType, string> Operators = new Dictionary<OperatorType, string>()
        {
            { OperatorType.EQUAL, "=" },
            { OperatorType.NOT_EQUAL, "!=" },
            { OperatorType.GREATER_THAN, ">" },
            { OperatorType.GREATER_OR_EQUAL, ">=" },
            { OperatorType.LESS_THAN, "<" },
            { OperatorType.LESS_OR_EQUAL, "<=" },
            { OperatorType.IN, "in" },
            { OperatorType.NOT_IN, "not" },
            { OperatorType.LIKE_SENSITIVE, "like" },
            { OperatorType.LIKE_INSENSITIVE, "ilike" }
        };
    }

}
