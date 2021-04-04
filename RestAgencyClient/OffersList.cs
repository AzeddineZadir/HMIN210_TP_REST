using Reservation_hotel_SW1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestAgencyClient
{
    public partial class OffersList : Form
    {

        private string dateArrivee;
        private string dateDepart;
        private int nbLits;
        private int id_roome;


        public OffersList(List <Rome> roomes , string dA, string dD, int nbL)
        {
            InitializeComponent();
            DataGridViewTextBoxColumn dgvIdCulumn = new DataGridViewTextBoxColumn();
            dgvIdCulumn.HeaderText = "ID";

            DataGridViewTextBoxColumn dgvTypeCulumn = new DataGridViewTextBoxColumn();
            dgvTypeCulumn.HeaderText = "Type chambre";

            DataGridViewTextBoxColumn dgvNbLitCulumn = new DataGridViewTextBoxColumn();
            dgvNbLitCulumn.HeaderText = "Nombre de lit";

            DataGridViewTextBoxColumn dgvPriceCulumn = new DataGridViewTextBoxColumn();
            dgvPriceCulumn.HeaderText = "Prix pour une nuits ";

            DataGridViewImageColumn dgimvc = new DataGridViewImageColumn();
            dgimvc.HeaderText = "Images ";
            dgimvc.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dgv_offers.Columns.Add(dgvIdCulumn);
            dgv_offers.Columns.Add(dgvTypeCulumn);
            dgv_offers.Columns.Add(dgvNbLitCulumn);
            dgv_offers.Columns.Add(dgvPriceCulumn);


            dgv_offers.Columns.Add(dgimvc);


            dgv_offers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_offers.RowTemplate.Height = 130;
            dgv_offers.AllowUserToAddRows = false;
            setImage(roomes);

            this.dateArrivee = dA;
            this.dateDepart = dD;
            this.nbLits = nbL;




        }

        async private void setImage(List<Rome> roomes)
        {
            foreach (var item in roomes)
            {


                var imageStr = await Requete.getImagebyId(item.Id);

                Image item_image = getImageFromString(imageStr);

                dgv_offers.Rows.Add(item.Id.ToString(), item.Type, item.Nb_bads.ToString(), item.Price.ToString(), item_image);
                
            }
        }

        private Image getImageFromString(string imgString)
        {

            byte[] imageByte = Convert.FromBase64String(imgString);
            System.IO.MemoryStream stream = new System.IO.MemoryStream(imageByte, 0, imageByte.Length);
            stream.Write(imageByte, 0, imageByte.Length);
            Image image = Image.FromStream(stream, true);

            return image;

        }

        async private void b_reserver_Click(object sender, EventArgs e)
        {
            string nomClient = tb_nom.Text;
            string prenomClient = tb_prenom.Text;
            string id = tb_room_id.Text;
            if (nomClient == "" || prenomClient == "" || id == "")
            {
                MessageBox.Show("Veuillez remplir tout les champs pour effectuer une reservation");
            }
            else
            {
                
                var roome = await Requete.reserveRome("a1", "a1", dateArrivee, dateDepart, Convert.ToInt32(tb_room_id.Text), tb_nom.Text, tb_prenom.Text);
                

                if (roome == null)
                {
                    MessageBox.Show("Nous somme désolés, l'offre n'est plus disponible, veuillez réessayer");
                }
                else
                {
                    MessageBox.Show("Chambre réservé " + roome.Id);

                    var imageStr = await Requete.getImagebyId(roome.Id);

                  

                    RoomDetailsForm roomeForme = new RoomDetailsForm(roome, imageStr);
                    roomeForme.Show();
                    this.Hide();
                }
            }






        }
    }
}
