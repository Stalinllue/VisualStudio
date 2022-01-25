using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaVSII
{
   public class Staff
    {
        public int staffID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int addressID { get; set; }
        public string email { get; set; }
        public int storeID { get; set; }
        public int active { get; set; }
        public string userName { get; set; }
        public string password { get; set; }

        public string picture { get; set; }
        public ICollection<Staff> Lista { get; set; }
    }
}
