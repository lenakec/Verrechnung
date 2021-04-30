
namespace Verrechnung.Forms
{
    partial class frmArtikel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbNeuanlage = new System.Windows.Forms.CheckBox();
            this.cbUst = new System.Windows.Forms.ComboBox();
            this.txtNettopreis = new System.Windows.Forms.TextBox();
            this.txtBezeichnung = new System.Windows.Forms.TextBox();
            this.txtArtikelID = new System.Windows.Forms.TextBox();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.lbUst = new System.Windows.Forms.Label();
            this.lbNettopreis = new System.Windows.Forms.Label();
            this.lbBezeichnung = new System.Windows.Forms.Label();
            this.lbArtikelID = new System.Windows.Forms.Label();
            this.lbModus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 338);
            this.panel1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(364, 338);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbNeuanlage);
            this.panel2.Controls.Add(this.cbUst);
            this.panel2.Controls.Add(this.txtNettopreis);
            this.panel2.Controls.Add(this.txtBezeichnung);
            this.panel2.Controls.Add(this.txtArtikelID);
            this.panel2.Controls.Add(this.btnSpeichern);
            this.panel2.Controls.Add(this.lbUst);
            this.panel2.Controls.Add(this.lbNettopreis);
            this.panel2.Controls.Add(this.lbBezeichnung);
            this.panel2.Controls.Add(this.lbArtikelID);
            this.panel2.Controls.Add(this.lbModus);
            this.panel2.Location = new System.Drawing.Point(410, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 338);
            this.panel2.TabIndex = 1;
            // 
            // cbNeuanlage
            // 
            this.cbNeuanlage.AutoSize = true;
            this.cbNeuanlage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNeuanlage.Location = new System.Drawing.Point(37, 228);
            this.cbNeuanlage.Name = "cbNeuanlage";
            this.cbNeuanlage.Size = new System.Drawing.Size(96, 19);
            this.cbNeuanlage.TabIndex = 10;
            this.cbNeuanlage.Text = "Neuanlage";
            this.cbNeuanlage.UseVisualStyleBackColor = true;
            this.cbNeuanlage.Click += new System.EventHandler(this.cbNeuanlage_Click);
            // 
            // cbUst
            // 
            this.cbUst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUst.FormattingEnabled = true;
            this.cbUst.Location = new System.Drawing.Point(137, 167);
            this.cbUst.Name = "cbUst";
            this.cbUst.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbUst.Size = new System.Drawing.Size(100, 21);
            this.cbUst.TabIndex = 9;
            // 
            // txtNettopreis
            // 
            this.txtNettopreis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNettopreis.Location = new System.Drawing.Point(137, 137);
            this.txtNettopreis.Multiline = true;
            this.txtNettopreis.Name = "txtNettopreis";
            this.txtNettopreis.Size = new System.Drawing.Size(100, 20);
            this.txtNettopreis.TabIndex = 8;
            // 
            // txtBezeichnung
            // 
            this.txtBezeichnung.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBezeichnung.Location = new System.Drawing.Point(137, 107);
            this.txtBezeichnung.Multiline = true;
            this.txtBezeichnung.Name = "txtBezeichnung";
            this.txtBezeichnung.Size = new System.Drawing.Size(219, 20);
            this.txtBezeichnung.TabIndex = 7;
            // 
            // txtArtikelID
            // 
            this.txtArtikelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArtikelID.Location = new System.Drawing.Point(137, 71);
            this.txtArtikelID.Multiline = true;
            this.txtArtikelID.Name = "txtArtikelID";
            this.txtArtikelID.ReadOnly = true;
            this.txtArtikelID.Size = new System.Drawing.Size(100, 20);
            this.txtArtikelID.TabIndex = 6;
            this.txtArtikelID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeichern.Location = new System.Drawing.Point(160, 219);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(184, 35);
            this.btnSpeichern.TabIndex = 5;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // lbUst
            // 
            this.lbUst.AutoSize = true;
            this.lbUst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUst.Location = new System.Drawing.Point(34, 168);
            this.lbUst.Name = "lbUst";
            this.lbUst.Size = new System.Drawing.Size(95, 15);
            this.lbUst.TabIndex = 4;
            this.lbUst.Text = "Umsatzsteuer";
            // 
            // lbNettopreis
            // 
            this.lbNettopreis.AutoSize = true;
            this.lbNettopreis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNettopreis.Location = new System.Drawing.Point(34, 138);
            this.lbNettopreis.Name = "lbNettopreis";
            this.lbNettopreis.Size = new System.Drawing.Size(73, 15);
            this.lbNettopreis.TabIndex = 3;
            this.lbNettopreis.Text = "Nettopreis";
            // 
            // lbBezeichnung
            // 
            this.lbBezeichnung.AutoSize = true;
            this.lbBezeichnung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBezeichnung.Location = new System.Drawing.Point(34, 107);
            this.lbBezeichnung.Name = "lbBezeichnung";
            this.lbBezeichnung.Size = new System.Drawing.Size(90, 15);
            this.lbBezeichnung.TabIndex = 2;
            this.lbBezeichnung.Text = "Bezeichnung";
            // 
            // lbArtikelID
            // 
            this.lbArtikelID.AutoSize = true;
            this.lbArtikelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArtikelID.Location = new System.Drawing.Point(34, 72);
            this.lbArtikelID.Name = "lbArtikelID";
            this.lbArtikelID.Size = new System.Drawing.Size(61, 15);
            this.lbArtikelID.TabIndex = 1;
            this.lbArtikelID.Text = "ArtikelID";
            // 
            // lbModus
            // 
            this.lbModus.AutoSize = true;
            this.lbModus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModus.Location = new System.Drawing.Point(133, 26);
            this.lbModus.Name = "lbModus";
            this.lbModus.Size = new System.Drawing.Size(62, 20);
            this.lbModus.TabIndex = 0;
            this.lbModus.Text = "Modus";
            // 
            // frmArtikel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 382);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmArtikel";
            this.Text = "  b";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmArtikel_FormClosing);
            this.Load += new System.EventHandler(this.frmArtikel_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox cbUst;
        private System.Windows.Forms.TextBox txtNettopreis;
        private System.Windows.Forms.TextBox txtBezeichnung;
        private System.Windows.Forms.TextBox txtArtikelID;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.Label lbUst;
        private System.Windows.Forms.Label lbNettopreis;
        private System.Windows.Forms.Label lbBezeichnung;
        private System.Windows.Forms.Label lbArtikelID;
        private System.Windows.Forms.Label lbModus;
        private System.Windows.Forms.CheckBox cbNeuanlage;
    }
}