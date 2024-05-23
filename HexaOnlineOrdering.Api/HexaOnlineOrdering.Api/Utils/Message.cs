using System;
using System.Collections.Generic;
using HexaOnlineOrdering.Models.Message;

namespace HexaOnlineOrdering.Api.Utils
{
    public class MessageUtil
    {
        public MessageUtil()
        {
        }

        public string GenerateSaleLineMessage(LineSaleMessageModel data)
        {
            List<string> messageList = new List<string>();
            if(!string.IsNullOrEmpty(data.ZoneName.Trim())){
                messageList.Add(data.ZoneName);
            }

            messageList.Add(string.Format("ออเดอร์ของ {0} {1} มีการสั่ง Online Order", data.DoctorName, data.ClinicName));
            messageList.Add(string.Format("คนไข้: {0}", data.PatientName));

            //if(data.ProductTypeCount != null)
            //{
            //    foreach(KeyValuePair<string, int> entry in data.ProductTypeCount)
            //    {
            //        if(entry.Value > 0)
            //        {
            //            messageList.Add(string.Format("{0}: จำนวน {1}", entry.Key, entry.Value));
            //        }
            //    }
            //}

            if(data.PickUpDate.HasValue)
            {
                DateTime thaiTime = ToThaiTime(data.PickUpDate.Value);
                messageList.Add(string.Format("รับงาน วันที่:{0} เวลา:{1}", thaiTime.ToString("dd MMM yyyy"), thaiTime.ToString("HH:mm")));
            }
                

            string result = string.Join("\n",messageList);
            return result;
        }

        /// <summary>
        /// [USE ONLY] convert to Thailand time on display from api 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public DateTime ToThaiTime(DateTime input)
        {
            TimeZoneInfo thaiZone = GetThaiTimeZoneInfo();
            DateTime thaiTime = TimeZoneInfo.ConvertTimeFromUtc(input, thaiZone);
            return thaiTime;
        }

        private TimeZoneInfo GetThaiTimeZoneInfo()
        {
            try
            {
                return TimeZoneInfo.FindSystemTimeZoneById("Asia/Bangkok");
            }
            catch
            {
                return TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time");
            }
        }
    }
}
