using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ServiceHotelRest.Models;
using Newtonsoft.Json;
using Reservation_hotel_SW1;

namespace RestAgencyClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        async private void b_rechercher_Click(object sender, EventArgs e)
        {
            if (tb_da.Text != "" && tb_dd.Text != "" && tb_nbp.Text != "" && tb_ville.Text != "")

            {
                // on verifie si lhotel se trouve dans la vile exiger par l'utilisateur si cest le cas on execute une requetes  pour récupereer les chmabres disponibles 
                // dans la periode saise par l'utilisateur 
                // string AgenceName, string AgencePwd, string DateDR, string DateFR, int NbPersonnes
                string AName = "a1";
                string APwd = "a1"; 
                int nbLits = Convert.ToInt32(tb_nbp.Text);
                string dateArriveString = tb_da.Text;
                string dateDepartString = tb_dd.Text;
                string ville = tb_ville.Text;


                /*
                var request = System.Net.HttpWebRequest.Create(string.Format(@"https://localhost:44348/api/Hotel/disponible_roomes/Hotel"));
                request.ContentType = "application/json";
                request.Method = "POST";

                SearchObject so = new SearchObject(AName,APwd, dateArriveString, dateDepartString, nbLits );

                String query = JsonConvert.SerializeObject(so);
                         */
                var free_roomes  =   await Requete.getOffres(AName, APwd, dateArriveString, dateDepartString, nbLits);
                Console.WriteLine(free_roomes);



                OffersList OffresListe = new OffersList(free_roomes, dateArriveString, dateDepartString, nbLits);
                OffresListe.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Veuillez remplir tout les champs pour effectuer une recherche ");
            }
        }
    
    
    
        

    
    
    }
}
