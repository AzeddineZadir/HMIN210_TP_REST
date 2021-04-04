using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reservation_hotel_SW1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceHotelRest.Service;
using ServiceHotelRest.Models;

namespace ServiceHotelRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private HotelService hotelService;

        public HotelController (HotelService hotelService)
        {
            this.hotelService = hotelService;
        }

        [HttpPost]
        [Route("disponible_roomes/[controller]")]
        public IActionResult GetDisponibilite([FromBody] SearchObject searchObject )
        {

            String AgenceName = searchObject.AgenceName;
            String AgencePwd = searchObject.AgencePwd;
            String DateDR = searchObject.DateDR;
            String DateFR = searchObject.DateFR;
            int NbPersonnes = searchObject.NbPersonnes;


            return Ok(hotelService.GetDisponibilites(AgenceName, AgencePwd, DateDR, DateFR, NbPersonnes));
        }

        [HttpPost]
        [Route("reserve_roome/[controller]")]
        public IActionResult ReserveRoome([FromBody] ReservationObject reservationObject)
        {
            string AgenceName = reservationObject.AgenceName;
            string AgencePwd = reservationObject.AgencePwd;
            string DateDR = reservationObject.DateDR;
            string DateFR = reservationObject.DateFR;
            int room_id = reservationObject.room_id;
            string nom = reservationObject.nom;
            string prenom = reservationObject.prenom;




            return Ok(hotelService.ReserveRoome(AgenceName,AgencePwd,DateDR,DateFR,room_id,nom,prenom));
        }


        [HttpGet]
        [Route("rome_image/[controller]/{rome_id}")]
        public IActionResult GetRomeImage(int rome_id)
        {
            

           return Ok(hotelService.SendImage(rome_id) );
        }

        [HttpGet]
        [Route("gotel/[controller]")]
        public IActionResult GetHotel()
        {

            return Ok(hotelService.GetHotel());
        }






    }


    


}
