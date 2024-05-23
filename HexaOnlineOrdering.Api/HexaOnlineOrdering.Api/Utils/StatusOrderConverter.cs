using HexaOnlineOrdering.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Api.Utils
{
    public static class StatusOrderConverter
    {

        public static string ConvertOrderStatusToString(int orderStatus)
        {
            switch (orderStatus)
            {
                case (int)OrderStatusEnum.draft:
                    return "pending";

                case (int)OrderStatusEnum.waitingOrder:
                    return "pending";
                case (int)OrderStatusEnum.ordered:
                    return "accepted";
                case (int)OrderStatusEnum.delivery:
                    return "delivered";
                case (int)OrderStatusEnum.completed:
                    return "completed";
                case (int)OrderStatusEnum.reject:
                    return "rejected";
                default: 
                    return "";
            }
        } 
    }
}
