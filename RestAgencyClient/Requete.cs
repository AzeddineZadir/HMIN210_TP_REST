using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Reservation_hotel_SW1;
using ServiceHotelRest.Models; 

namespace RestAgencyClient
{
    public static class Requete
    {



        public static  async Task<List<Rome>> getOffres(string agenceName, string agencePwd, string dateDR, string dateFR, int nbPersonnes)
        {
            SearchObject c = new SearchObject(agenceName, agencePwd, dateDR, dateFR, nbPersonnes);
                     
            String query = JsonConvert.SerializeObject(c);

            List<Rome> roomes = new List<Rome>(); 

            StringContent content = new StringContent(query, Encoding.UTF8, "application/json");
            
                    string link = "https://localhost:44348/api/Hotel/disponible_roomes/Hotel";
                    Console.WriteLine("Contacting " + link);
                    try
                    {
                        using (var httpClient = new HttpClient())
                        {
                            using (var response = await httpClient.PostAsync(link, content))
                            {
                                string apiResponse = await response.Content.ReadAsStringAsync();

                                 roomes  = JsonConvert.DeserializeObject<List<Rome>>(apiResponse);
                                foreach (Rome ch in roomes)
                                {
                                     Console.WriteLine(ch.Id);
                                }
                               
                            }
                        }
                    }
                    catch (Exception e)
                    {

                    

                    }

            return roomes;
        }


        public static async Task<String> getImagebyId(int image_id) {
            String resImage = " "; 
/*  
            String query = JsonConvert.SerializeObject(image_id);*/

           /* Console.WriteLine(query);*/

           /* StringContent content = new StringContent(query, Encoding.UTF8, "application/json");*/
            
                    string link = "https://localhost:44348/api/Hotel/rome_image/Hotel/" + image_id;
                    Console.WriteLine("Contacting " + link);
                    try
                    {
                        using (var httpClient = new HttpClient())
                        {
                            using (var response = await httpClient.GetAsync(link))
                            {
                                string apiResponse = await response.Content.ReadAsStringAsync();

                                    Console.WriteLine(apiResponse);
                                    resImage = apiResponse;


                    }
                        }
                    }
                    catch (Exception e)
                    {

                         Console.WriteLine(e.Message);
                    

                    }


            return resImage;
        }

            
        public static async Task<Rome> reserveRome (string AgenceName, string AgencePwd, string DateDR, string DateFR, int room_id, string nom, string prenom)
        {

            ReservationObject c = new ReservationObject(AgenceName, AgencePwd, DateDR, DateFR, room_id,nom , prenom);

            String query = JsonConvert.SerializeObject(c);

            Rome roome = new Rome();

            StringContent content = new StringContent(query, Encoding.UTF8, "application/json");

            string link = "https://localhost:44348/api/Hotel/reserve_roome/Hotel";
            Console.WriteLine("Contacting " + link);
            try
            {
                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.PostAsync(link, content))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();

                        roome= JsonConvert.DeserializeObject<Rome>(apiResponse);
                       

                    }
                }
            }
            catch (Exception e)
            {



            }

            return roome;
        }
    }
}
