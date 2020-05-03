using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStoreData.Models
{
    public class OrderCount
    {
       
        
        public DateTimeOffset StartDate { get; }
        public DateTimeOffset EndDate { get; } 
        public int TotalOrderCount { get; }

        
        internal OrderCount(DateTimeOffset startdate, DateTimeOffset enddate, int totalordercount)
        {
            StartDate = startdate;
            EndDate = enddate;
            TotalOrderCount = totalordercount;
        }



    }
}
