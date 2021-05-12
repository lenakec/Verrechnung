﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verrechnung.Forms
{
    public partial class frmUmsatzsteuer : Form
    {
        public frmUmsatzsteuer()
        {
            InitializeComponent();
        }

        #region Variablen
        Datenbank db;
        ListViewItem lvItem;
        OleDbDataReader dr;
        //List<int> ustListe;
        string sql;
        #endregion

        private void frmUmsatzsteuer_Load(object sender, EventArgs e)
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
        }

        private void frmUmsatzsteuer_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmStart.f1.btnUmsatzsteuer.BackColor = frmStart.f1.btnBackColor;
            frmStart.f1.btnUmsatzsteuer.ForeColor = frmStart.f1.btnForeColor;
            frmStart.f1.frmUst = null;
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {

        }
    }
}
