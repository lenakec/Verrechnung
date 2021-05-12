using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Verrechnung.Forms
{
    public partial class frmKunde : Form
    {
        public frmKunde()
        {
            InitializeComponent();
        }
        #region Variablen
        Datenbank db;
        ListViewItem lvItem;
        OleDbDataReader dr;
        List<int> plzListe;
        string sql;
        #endregion

        private void frmKunde_Load(object sender, EventArgs e)
        {
            this.Height = frmStart.f1.displayHeight;
            this.Width = frmStart.f1.Width * 4;
            this.Location = new Point(frmStart.f1.Width, 0);
            this.BackColor = frmStart.f1.btnBackColor;
            this.ForeColor = frmStart.f1.btnForeColor;
            btnSpeichern.ForeColor = frmStart.f1.btnBackColor;
            btnSpeichern.BackColor = frmStart.f1.btnForeColor;

            //Panels ein/ausrichten
            panel1.Width = this.Width / 5 * 3;
            panel2.Width = this.Width / 5 * 2;
            panel1.Height = this.Height;
            panel2.Height = this.Height;
            //panel1.BackColor = Color.Gray;
            //panel2.BackColor = Color.DarkGray;
            panel1.Location = new Point(0, 0);
            panel2.Location = new Point(panel1.Width, 0);


            //ListView1 einrichten
            listView1.FullRowSelect = true;
            listView1.View = View.Details;
            listView1.Columns.Add("KundeID");
            listView1.Columns.Add("Unternehmen");
            listView1.Columns.Add("Ansprechperson");
            listView1.Columns.Add("Telefon");
            listView1.Columns.Add("Email");
            listView1.Columns.Add("PLZ");
            listView1.Columns.Add("Ort");
            listView1.Columns.Add("Strasse");
            listView1.Columns.Add("Zahlungskondition");
            listView1.Font = new Font("Arial", 12, FontStyle.Bold);

            //Datenbankobjekt initialisieren
            db = new Datenbank();

            //ListePLZ initialisieren
            plzListe = new List<int>();
         
          
            einlesenKunden();
            einlesenPLZ();
            cbPLZ.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbPLZ.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        #region Methoden
        private void einlesenKunden()
        {
            listView1.Items.Clear();
            sql = "Select * from queryKunden; ";
            dr = db.Einlesen(sql);
            while (dr.Read())
            {
                lvItem = new ListViewItem(dr[0].ToString());
                lvItem.SubItems.Add(dr[1].ToString());
                lvItem.SubItems.Add(dr[2].ToString());
                lvItem.SubItems.Add(dr[3].ToString());
                lvItem.SubItems.Add(dr[4].ToString());
                lvItem.SubItems.Add(dr[5].ToString());
                lvItem.SubItems.Add(dr[6].ToString());
                lvItem.SubItems.Add(dr[7].ToString());
                lvItem.SubItems.Add(dr[8].ToString());
                listView1.Items.Add(lvItem);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }
        private void einlesenPLZ()
        {
            sql = "Select * from Postleitzahl;";
            dr = db.Einlesen(sql);
            while(dr.Read())
            {
                cbPLZ.Items.Add(dr[1].ToString() + " " + dr[2].ToString());
                plzListe.Add(Convert.ToInt32(dr[0].ToString()));

            }

        }

        #endregion

        private void frmKunde_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmStart.f1.btnKunde.BackColor = frmStart.f1.btnBackColor;
            frmStart.f1.btnKunde.ForeColor = frmStart.f1.btnForeColor;
            frmStart.f1.frmKun = null;
        }

        private void cbNeuanlage_Click(object sender, EventArgs e)
        {
            if (cbNeuanlage.Checked)
            {
                int artID = db.BerechnenInt("SELECT MAX(KundeID) FROM Kunde") + 1;
                lbModus.Text = "Kunde anlegen";
                txtKundeID.Text = artID.ToString();
                txtUnternehmen.Clear();
                txtAnsprechperson.Clear();
                txtTelefon.Clear();
                txtEmail.Clear();
                txtStrasse.Clear();
                txtZahlungskondition.Clear();
                cbPLZ.SelectedIndex = -1;

            }
            else
            {
                MessageBox.Show("Wenn Sie einen Kunden bearbeiten wollen, klicken Sie auf diesen!");
                cbNeuanlage.Checked = true;
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            lvItem = listView1.SelectedItems[0];
            lbModus.Text = "Kunden bearbeiten";
            txtKundeID.Text = lvItem.SubItems[0].Text;
            txtUnternehmen.Text = lvItem.SubItems[1].Text;
            txtAnsprechperson.Text = lvItem.SubItems[2].Text;
            txtTelefon.Text = lvItem.SubItems[3].Text;
            txtEmail.Text = lvItem.SubItems[4].Text;
            cbPLZ.Text = lvItem.SubItems[5].Text + " " + lvItem.SubItems[6].Text;
            txtStrasse.Text = lvItem.SubItems[7].Text;
            txtZahlungskondition.Text = lvItem.SubItems[8].Text;

            cbNeuanlage.Checked = false; //wenn man auf Bearbeiten klicken
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            if(txtUnternehmen.Text.Equals("") || txtAnsprechperson.Text.Equals("") || txtTelefon.Text.Equals("") || txtEmail.Text.Equals("") || txtZahlungskondition.Text.Equals(""))
            {
                MessageBox.Show("Bitte geben Sie sowohl Unternehmen, Ansprechperson, Telefon, Email als auch Zahlungskondition ein!");
                return;
            }

            if(cbPLZ.SelectedIndex == -1)
            {
                MessageBox.Show("Bitte wählen Sie PLZ und Ort aus!");
                return;
            }
            if(cbNeuanlage.Checked)
            {
                sql = @"Insert into Kunde (Unternehmen, Ansprechperson, Telefon, Email, Strasse, Zahlungskondition, PostleitzahlID)
                        values ('" + txtUnternehmen.Text + "' , '" + txtAnsprechperson.Text + "' , '" + txtTelefon.Text + "' , '" +
                        txtEmail.Text + "' , '" + txtStrasse.Text + "' , '" + txtZahlungskondition.Text + "' , " +
                        plzListe[cbPLZ.SelectedIndex] + ");";
                MessageBox.Show(sql);
                db.Ausfuehren(sql);
                einlesenKunden();
            }
            else //Bearbeiten
            {
                //Test
              
            }
           
        }
    }
}
