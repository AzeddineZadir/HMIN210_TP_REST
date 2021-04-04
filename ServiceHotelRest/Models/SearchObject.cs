using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceHotelRest.Models
{
    public class SearchObject
    {

        public string AgenceName { get; set; }
        public string AgencePwd { get; set; }
        public string DateDR { get; set; }
        public string DateFR { get; set; }
        public int NbPersonnes { get; set; }
    }
}
