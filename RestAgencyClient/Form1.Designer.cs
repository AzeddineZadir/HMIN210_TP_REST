
namespace RestAgencyClient
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_ville = new System.Windows.Forms.TextBox();
            this.tb_da = new System.Windows.Forms.TextBox();
            this.tb_dd = new System.Windows.Forms.TextBox();
            this.tb_nbp = new System.Windows.Forms.TextBox();
            this.b_rechercher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(473, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agence A1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(358, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(364, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vous voulez reserver une chambre ?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(288, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ville";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(288, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre de personnes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(288, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date  Départ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(288, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date Arrivée";
            // 
            // tb_ville
            // 
            this.tb_ville.Location = new System.Drawing.Point(529, 116);
            this.tb_ville.Name = "tb_ville";
            this.tb_ville.Size = new System.Drawing.Size(232, 20);
            this.tb_ville.TabIndex = 6;
            this.tb_ville.Text = "A+";
            // 
            // tb_da
            // 
            this.tb_da.Location = new System.Drawing.Point(529, 165);
            this.tb_da.Name = "tb_da";
            this.tb_da.Size = new System.Drawing.Size(232, 20);
            this.tb_da.TabIndex = 7;
            this.tb_da.Text = "10/10/2020";
            // 
            // tb_dd
            // 
            this.tb_dd.Location = new System.Drawing.Point(529, 211);
            this.tb_dd.Name = "tb_dd";
            this.tb_dd.Size = new System.Drawing.Size(232, 20);
            this.tb_dd.TabIndex = 8;
            this.tb_dd.Text = "12/10/2020";
            // 
            // tb_nbp
            // 
            this.tb_nbp.Location = new System.Drawing.Point(529, 255);
            this.tb_nbp.Name = "tb_nbp";
            this.tb_nbp.Size = new System.Drawing.Size(232, 20);
            this.tb_nbp.TabIndex = 9;
            this.tb_nbp.Text = "1";
            // 
            // b_rechercher
            // 
            this.b_rechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_rechercher.Location = new System.Drawing.Point(478, 351);
            this.b_rechercher.Name = "b_rechercher";
            this.b_rechercher.Size = new System.Drawing.Size(129, 38);
            this.b_rechercher.TabIndex = 10;
            this.b_rechercher.Text = "Rechercher ";
            this.b_rechercher.UseVisualStyleBackColor = true;
            this.b_rechercher.Click += new System.EventHandler(this.b_rechercher_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 507);
            this.Controls.Add(this.b_rechercher);
            this.Controls.Add(this.tb_nbp);
            this.Controls.Add(this.tb_dd);
            this.Controls.Add(this.tb_da);
            this.Controls.Add(this.tb_ville);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_ville;
        private System.Windows.Forms.TextBox tb_da;
        private System.Windows.Forms.TextBox tb_dd;
        private System.Windows.Forms.TextBox tb_nbp;
        private System.Windows.Forms.Button b_rechercher;
    }
}

