
namespace Verrechnung.Forms
{
    partial class frmUmsatzsteuer
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbModus = new System.Windows.Forms.Label();
            this.lbUmsatzsteuerID = new System.Windows.Forms.Label();
            this.txtUstSatz = new System.Windows.Forms.TextBox();
            this.lbUstSatz = new System.Windows.Forms.Label();
            this.cbNeuanlage = new System.Windows.Forms.CheckBox();
            this.txtUmsatzsteuerID = new System.Windows.Forms.TextBox();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 398);
            this.panel1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(285, 398);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Location = new System.Drawing.Point(309, 8);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(449, 398);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Controls.Add(this.lbModus, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbUmsatzsteuerID, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtUstSatz, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbUstSatz, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbNeuanlage, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtUmsatzsteuerID, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSpeichern, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(449, 398);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbModus
            // 
            this.lbModus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbModus.AutoSize = true;
            this.lbModus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModus.Location = new System.Drawing.Point(198, 50);
            this.lbModus.Name = "lbModus";
            this.lbModus.Size = new System.Drawing.Size(62, 20);
            this.lbModus.TabIndex = 1;
            this.lbModus.Text = "Modus";
            // 
            // lbUmsatzsteuerID
            // 
            this.lbUmsatzsteuerID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbUmsatzsteuerID.AutoSize = true;
            this.lbUmsatzsteuerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUmsatzsteuerID.Location = new System.Drawing.Point(22, 81);
            this.lbUmsatzsteuerID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUmsatzsteuerID.Name = "lbUmsatzsteuerID";
            this.lbUmsatzsteuerID.Size = new System.Drawing.Size(129, 18);
            this.lbUmsatzsteuerID.TabIndex = 2;
            this.lbUmsatzsteuerID.Text = "UmsatzsteuerID";
            // 
            // txtUstSatz
            // 
            this.txtUstSatz.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUstSatz.Location = new System.Drawing.Point(197, 116);
            this.txtUstSatz.Margin = new System.Windows.Forms.Padding(2);
            this.txtUstSatz.Multiline = true;
            this.txtUstSatz.Name = "txtUstSatz";
            this.txtUstSatz.Size = new System.Drawing.Size(208, 27);
            this.txtUstSatz.TabIndex = 5;
            // 
            // lbUstSatz
            // 
            this.lbUstSatz.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbUstSatz.AutoSize = true;
            this.lbUstSatz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUstSatz.Location = new System.Drawing.Point(22, 121);
            this.lbUstSatz.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUstSatz.Name = "lbUstSatz";
            this.lbUstSatz.Size = new System.Drawing.Size(68, 18);
            this.lbUstSatz.TabIndex = 3;
            this.lbUstSatz.Text = "UstSatz";
            // 
            // cbNeuanlage
            // 
            this.cbNeuanlage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbNeuanlage.AutoSize = true;
            this.cbNeuanlage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNeuanlage.Location = new System.Drawing.Point(23, 174);
            this.cbNeuanlage.Name = "cbNeuanlage";
            this.cbNeuanlage.Size = new System.Drawing.Size(106, 22);
            this.cbNeuanlage.TabIndex = 0;
            this.cbNeuanlage.Text = "Neuanlage";
            this.cbNeuanlage.UseVisualStyleBackColor = true;
            // 
            // txtUmsatzsteuerID
            // 
            this.txtUmsatzsteuerID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUmsatzsteuerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUmsatzsteuerID.Location = new System.Drawing.Point(197, 77);
            this.txtUmsatzsteuerID.Margin = new System.Windows.Forms.Padding(2);
            this.txtUmsatzsteuerID.Multiline = true;
            this.txtUmsatzsteuerID.Name = "txtUmsatzsteuerID";
            this.txtUmsatzsteuerID.ReadOnly = true;
            this.txtUmsatzsteuerID.Size = new System.Drawing.Size(96, 25);
            this.txtUmsatzsteuerID.TabIndex = 4;
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSpeichern.Location = new System.Drawing.Point(197, 169);
            this.btnSpeichern.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(208, 32);
            this.btnSpeichern.TabIndex = 6;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            // 
            // frmUmsatzsteuer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 428);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmUmsatzsteuer";
            this.Text = "frmUmsatzsteuer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUmsatzsteuer_FormClosing);
            this.Load += new System.EventHandler(this.frmUmsatzsteuer_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbModus;
        private System.Windows.Forms.Label lbUmsatzsteuerID;
        private System.Windows.Forms.Label lbUstSatz;
        private System.Windows.Forms.TextBox txtUmsatzsteuerID;
        private System.Windows.Forms.TextBox txtUstSatz;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.CheckBox cbNeuanlage;
    }
}