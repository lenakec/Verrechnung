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
using System.Data.OleDb;
using System.Data;


namespace Verrechnung.Forms
{
    public partial class frmArtikel : Form
    {
        public frmArtikel()
        {
            InitializeComponent();
        }

        #region Variablen
        string sql;
        ListViewItem lvItem;
        OleDbDataReader dr;
        Datenbank db;
        List<int> listUst;
        #endregion

        private void frmArtikel_Load(object sender, EventArgs e)
        {
            //frmArtikel am Bildschrim / frmStart ausrichten
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
            listView1.Columns.Add("ArtikelID");
            listView1.Columns.Add("Bezeichnung");
            listView1.Columns.Add("Nettopreis").TextAlign = HorizontalAlignment.Right;
            listView1.Columns.Add("Umsatzsteuersatz").TextAlign = HorizontalAlignment.Right;
            listView1.Font = new Font("Arial", 12, FontStyle.Bold);

            //Datenbankobjekt initialisieren
            db = new Datenbank();
          
            //ListeUst initialisieren
            listUst = new List<int>();

            einlesenArtikel();
            einlesenUst();
           // cbUst.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbUst.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        #region Methoden
        private void einlesenArtikel()
        {
            listView1.Items.Clear();
            sql = "SELECT a.ArtikelID, a.Bezeichnung, a.Nettopreis, u.UstSatz FROM Artikel a, Umsatzsteuer u WHERE a.UmsatzsteuerID = u.UmsatzsteuerID";
            dr = db.Einlesen(sql);
            while(dr.Read())
            {
                lvItem = new ListViewItem(dr[0].ToString());
                lvItem.SubItems.Add(dr[1].ToString());
                lvItem.SubItems.Add(dr[2].ToString());
                lvItem.SubItems.Add(dr[3].ToString());
                listView1.Items.Add(lvItem);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        internal void einlesenUst()
        {
            cbUst.Items.Clear();
            sql = "SELECT * FROM Umsatzsteuer";
            dr = db.Einlesen(sql);
            while(dr.Read())
            {             
                cbUst.Items.Add(dr[1].ToString());
                listUst.Add(Convert.ToInt16(dr[0].ToString()));
            }
        }

        #endregion

        private void frmArtikel_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmStart.f1.btnArtikel.BackColor = frmStart.f1.btnBackColor;
            frmStart.f1.btnArtikel.ForeColor = frmStart.f1.btnForeColor;
            frmStart.f1.frmArt = null;
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            //if (listView1.SelectedItems.Count == 0)
            //{
            //    MessageBox.Show("Bitte wählen Sie einen Artikel aus!");
            //    return;
            //} Nicht notwendig!

            lvItem = listView1.SelectedItems[0];
            lbModus.Text = "Artikel bearbeiten";
            txtArtikelID.Text = lvItem.SubItems[0].Text;
            txtBezeichnung.Text = lvItem.SubItems[1].Text;
            txtNettopreis.Text = lvItem.SubItems[2].Text;
            cbUst.Text = lvItem.SubItems[3].Text;

            cbNeuanlage.Checked = false; //wenn man auf Bearbeiten klicken

        }

        private void cbNeuanlage_Click(object sender, EventArgs e)
        {
            if(cbNeuanlage.Checked)
            {
                int artID = db.BerechnenInt("SELECT MAX(ArtikelID) FROM Artikel") + 1;
                lbModus.Text = "Artikel anlegen";
                txtArtikelID.Text = artID.ToString();
                txtBezeichnung.Clear();
                txtNettopreis.Clear();
                cbUst.SelectedIndex = -1;
                    
            }
            else
            {
                MessageBox.Show("Wenn Sie einen Artikel bearbeiten wollen, klicken Sie auf diesen!");
                cbNeuanlage.Checked = true;
            }
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            double preis = 0;
            if(txtBezeichnung.Text.Equals(""))
            {
                MessageBox.Show("Bitte geben Sie eine Bezeichnung ein!");
                return;
            }
            try
            {
                preis = Double.Parse(txtNettopreis.Text, System.Globalization.NumberStyles.Currency);
            }
            catch
            {
                MessageBox.Show("Bitte geben Sie einen gültigen Preis ein!");
                return;
            }
            if(cbUst.SelectedIndex == -1)
            {
                MessageBox.Show("Bitte wählen Sie einen Umsatz-Steuersatz aus!");
                return;
            }
            if(cbNeuanlage.Checked)
            {
                try
                {
                    sql = "INSERT INTO Artikel (Bezeichnung, Nettopreis, UmsatzsteuerID) VALUES ('" + txtBezeichnung.Text + "', " + preis + "," + listUst[cbUst.SelectedIndex] + ")";
                    //MessageBox.Show(sql);
                    db.Ausfuehren(sql);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
             
            }
            else //Bearbeiten
            {
                try
                {
                    sql = "UPDATE Artikel SET Bezeichnung = '" + txtBezeichnung.Text + "', Nettopreis = " + preis + ", UmsatzsteuerID = " + listUst[cbUst.SelectedIndex] + " WHERE ArtikelID = " + Convert.ToInt16(txtArtikelID.Text);
                    //MessageBox.Show(sql);
                    db.Ausfuehren(sql);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            einlesenArtikel();
        }
    }
}
