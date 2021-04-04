using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceHotelRest.Models
{
    public class ReservationObject
    {
        public string AgenceName { get; set; }
        public string AgencePwd { get; set; }
        public string DateDR { get; set; }
        public string DateFR { get; set; }
        public int room_id { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }

        public ReservationObject(string agenceName, string agencePwd, string dateDR, string dateFR, int room_id, string nom, string prenom)
        {
            AgenceName = agenceName;
            AgencePwd = agencePwd;
            DateDR = dateDR;
            DateFR = dateFR;
            this.room_id = room_id;
            this.nom = nom;
            this.prenom = prenom;
        }
    }
}
