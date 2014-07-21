namespace PenezniDenik
{
    partial class New
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
            this.textBoxSlovy = new System.Windows.Forms.TextBox();
            this.labelCenaSlovy = new System.Windows.Forms.Label();
            this.textBoxFirma = new System.Windows.Forms.TextBox();
            this.labelFirma = new System.Windows.Forms.Label();
            this.textBoxUcelP = new System.Windows.Forms.TextBox();
            this.labelUcelPlatby = new System.Windows.Forms.Label();
            this.comboBoxTypPlatby = new System.Windows.Forms.ComboBox();
            this.labelTypPlatby = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.textBoxCelemKC = new System.Windows.Forms.TextBox();
            this.textBoxDPHzc = new System.Windows.Forms.TextBox();
            this.textBoxDPH = new System.Windows.Forms.TextBox();
            this.textBoxCenabBDPH = new System.Windows.Forms.TextBox();
            this.labelCelkem = new System.Windows.Forms.Label();
            this.labelDPH = new System.Windows.Forms.Label();
            this.labelCena = new System.Windows.Forms.Label();
            this.textBoxčisloPD = new System.Windows.Forms.TextBox();
            this.DatePickerDatumPD = new System.Windows.Forms.DateTimePicker();
            this.comboBoxTypDokladu = new System.Windows.Forms.ComboBox();
            this.labelCislo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.souborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vlozitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zavřítToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiskPokladníhoListkuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelDIC = new System.Windows.Forms.Label();
            this.textBoxDIC = new System.Windows.Forms.TextBox();
            this.labelVyplacene = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonVloz = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonVloz);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.labelVyplacene);
            this.panel1.Controls.Add(this.textBoxDIC);
            this.panel1.Controls.Add(this.labelDIC);
            this.panel1.Controls.Add(this.textBoxSlovy);
            this.panel1.Controls.Add(this.labelCenaSlovy);
            this.panel1.Controls.Add(this.textBoxFirma);
            this.panel1.Controls.Add(this.labelFirma);
            this.panel1.Controls.Add(this.textBoxUcelP);
            this.panel1.Controls.Add(this.labelUcelPlatby);
            this.panel1.Controls.Add(this.comboBoxTypPlatby);
            this.panel1.Controls.Add(this.labelTypPlatby);
            this.panel1.Controls.Add(this.labelDay);
            this.panel1.Controls.Add(this.textBoxCelemKC);
            this.panel1.Controls.Add(this.textBoxDPHzc);
            this.panel1.Controls.Add(this.textBoxDPH);
            this.panel1.Controls.Add(this.textBoxCenabBDPH);
            this.panel1.Controls.Add(this.labelCelkem);
            this.panel1.Controls.Add(this.labelDPH);
            this.panel1.Controls.Add(this.labelCena);
            this.panel1.Controls.Add(this.textBoxčisloPD);
            this.panel1.Controls.Add(this.DatePickerDatumPD);
            this.panel1.Controls.Add(this.comboBoxTypDokladu);
            this.panel1.Controls.Add(this.labelCislo);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 278);
            this.panel1.TabIndex = 0;
            // 
            // textBoxSlovy
            // 
            this.textBoxSlovy.Location = new System.Drawing.Point(496, 155);
            this.textBoxSlovy.Name = "textBoxSlovy";
            this.textBoxSlovy.Size = new System.Drawing.Size(145, 20);
            this.textBoxSlovy.TabIndex = 20;
            this.textBoxSlovy.Text = "DOPLŇIT";
            this.textBoxSlovy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSlovy.TextChanged += new System.EventHandler(this.textBox2_Enter);
            this.textBoxSlovy.Enter += new System.EventHandler(this.textBox2_Enter);
            // 
            // labelCenaSlovy
            // 
            this.labelCenaSlovy.AutoSize = true;
            this.labelCenaSlovy.Location = new System.Drawing.Point(457, 158);
            this.labelCenaSlovy.Name = "labelCenaSlovy";
            this.labelCenaSlovy.Size = new System.Drawing.Size(33, 13);
            this.labelCenaSlovy.TabIndex = 19;
            this.labelCenaSlovy.Text = "Slovy";
            // 
            // textBoxFirma
            // 
            this.textBoxFirma.Location = new System.Drawing.Point(56, 62);
            this.textBoxFirma.Multiline = true;
            this.textBoxFirma.Name = "textBoxFirma";
            this.textBoxFirma.Size = new System.Drawing.Size(138, 59);
            this.textBoxFirma.TabIndex = 18;
            // 
            // labelFirma
            // 
            this.labelFirma.AutoSize = true;
            this.labelFirma.Location = new System.Drawing.Point(12, 65);
            this.labelFirma.Name = "labelFirma";
            this.labelFirma.Size = new System.Drawing.Size(38, 13);
            this.labelFirma.TabIndex = 17;
            this.labelFirma.Text = "Firma: ";
            // 
            // textBoxUcelP
            // 
            this.textBoxUcelP.Location = new System.Drawing.Point(277, 105);
            this.textBoxUcelP.Name = "textBoxUcelP";
            this.textBoxUcelP.Size = new System.Drawing.Size(153, 20);
            this.textBoxUcelP.TabIndex = 16;
            this.textBoxUcelP.Text = "DOPLŇIT";
            this.textBoxUcelP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxUcelP.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // labelUcelPlatby
            // 
            this.labelUcelPlatby.AutoSize = true;
            this.labelUcelPlatby.Location = new System.Drawing.Point(211, 108);
            this.labelUcelPlatby.Name = "labelUcelPlatby";
            this.labelUcelPlatby.Size = new System.Drawing.Size(60, 13);
            this.labelUcelPlatby.TabIndex = 15;
            this.labelUcelPlatby.Text = "Účel platby";
            // 
            // comboBoxTypPlatby
            // 
            this.comboBoxTypPlatby.FormattingEnabled = true;
            this.comboBoxTypPlatby.Items.AddRange(new object[] {
            "V Hotovosti",
            "Bankovní převod"});
            this.comboBoxTypPlatby.Location = new System.Drawing.Point(277, 65);
            this.comboBoxTypPlatby.Name = "comboBoxTypPlatby";
            this.comboBoxTypPlatby.Size = new System.Drawing.Size(153, 21);
            this.comboBoxTypPlatby.TabIndex = 14;
            // 
            // labelTypPlatby
            // 
            this.labelTypPlatby.AutoSize = true;
            this.labelTypPlatby.Location = new System.Drawing.Point(211, 71);
            this.labelTypPlatby.Name = "labelTypPlatby";
            this.labelTypPlatby.Size = new System.Drawing.Size(62, 13);
            this.labelTypPlatby.TabIndex = 13;
            this.labelTypPlatby.Text = "Typ platby: ";
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Location = new System.Drawing.Point(457, 37);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(42, 13);
            this.labelDay.TabIndex = 12;
            this.labelDay.Text = "ze dne:";
            // 
            // textBoxCelemKC
            // 
            this.textBoxCelemKC.Location = new System.Drawing.Point(541, 129);
            this.textBoxCelemKC.Name = "textBoxCelemKC";
            this.textBoxCelemKC.Size = new System.Drawing.Size(100, 20);
            this.textBoxCelemKC.TabIndex = 10;
            this.textBoxCelemKC.Text = "0000";
            // 
            // textBoxDPHzc
            // 
            this.textBoxDPHzc.Location = new System.Drawing.Point(541, 100);
            this.textBoxDPHzc.Name = "textBoxDPHzc";
            this.textBoxDPHzc.Size = new System.Drawing.Size(100, 20);
            this.textBoxDPHzc.TabIndex = 9;
            this.textBoxDPHzc.Text = "00";
            // 
            // textBoxDPH
            // 
            this.textBoxDPH.Location = new System.Drawing.Point(460, 100);
            this.textBoxDPH.Name = "textBoxDPH";
            this.textBoxDPH.Size = new System.Drawing.Size(37, 20);
            this.textBoxDPH.TabIndex = 8;
            this.textBoxDPH.Text = "0";
            this.textBoxDPH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxDPH.TextChanged += new System.EventHandler(this.textBoxDPH_TextChanged);
            // 
            // textBoxCenabBDPH
            // 
            this.textBoxCenabBDPH.Location = new System.Drawing.Point(541, 68);
            this.textBoxCenabBDPH.Name = "textBoxCenabBDPH";
            this.textBoxCenabBDPH.Size = new System.Drawing.Size(100, 20);
            this.textBoxCenabBDPH.TabIndex = 7;
            this.textBoxCenabBDPH.Text = "0000";
            this.textBoxCenabBDPH.TextChanged += new System.EventHandler(this.textBoxCenabBDPH_TextChanged);
            // 
            // labelCelkem
            // 
            this.labelCelkem.AutoSize = true;
            this.labelCelkem.Location = new System.Drawing.Point(477, 132);
            this.labelCelkem.Name = "labelCelkem";
            this.labelCelkem.Size = new System.Drawing.Size(58, 13);
            this.labelCelkem.TabIndex = 6;
            this.labelCelkem.Text = "Celkem Kč";
            // 
            // labelDPH
            // 
            this.labelDPH.AutoSize = true;
            this.labelDPH.Location = new System.Drawing.Point(494, 103);
            this.labelDPH.Name = "labelDPH";
            this.labelDPH.Size = new System.Drawing.Size(41, 13);
            this.labelDPH.TabIndex = 5;
            this.labelDPH.Text = "% DPH";
            // 
            // labelCena
            // 
            this.labelCena.AutoSize = true;
            this.labelCena.Location = new System.Drawing.Point(457, 71);
            this.labelCena.Name = "labelCena";
            this.labelCena.Size = new System.Drawing.Size(78, 13);
            this.labelCena.TabIndex = 4;
            this.labelCena.Text = "Cena bez DPH";
            // 
            // textBoxčisloPD
            // 
            this.textBoxčisloPD.Location = new System.Drawing.Point(277, 28);
            this.textBoxčisloPD.Name = "textBoxčisloPD";
            this.textBoxčisloPD.Size = new System.Drawing.Size(153, 20);
            this.textBoxčisloPD.TabIndex = 3;
            // 
            // DatePickerDatumPD
            // 
            this.DatePickerDatumPD.Location = new System.Drawing.Point(524, 31);
            this.DatePickerDatumPD.Name = "DatePickerDatumPD";
            this.DatePickerDatumPD.Size = new System.Drawing.Size(117, 20);
            this.DatePickerDatumPD.TabIndex = 2;
            // 
            // comboBoxTypDokladu
            // 
            this.comboBoxTypDokladu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxTypDokladu.FormattingEnabled = true;
            this.comboBoxTypDokladu.Items.AddRange(new object[] {
            "Výdajový",
            "Příjmový"});
            this.comboBoxTypDokladu.Location = new System.Drawing.Point(56, 27);
            this.comboBoxTypDokladu.Name = "comboBoxTypDokladu";
            this.comboBoxTypDokladu.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTypDokladu.TabIndex = 1;
            this.comboBoxTypDokladu.SelectedIndexChanged += new System.EventHandler(this.textBoxTyp_SelectedIndexChanged);
            // 
            // labelCislo
            // 
            this.labelCislo.AutoSize = true;
            this.labelCislo.Location = new System.Drawing.Point(183, 31);
            this.labelCislo.Name = "labelCislo";
            this.labelCislo.Size = new System.Drawing.Size(99, 13);
            this.labelCislo.TabIndex = 0;
            this.labelCislo.Text = "pokladní doklad č: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.souborToolStripMenuItem,
            this.tiskToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(653, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // souborToolStripMenuItem
            // 
            this.souborToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vlozitToolStripMenuItem,
            this.zavřítToolStripMenuItem});
            this.souborToolStripMenuItem.Name = "souborToolStripMenuItem";
            this.souborToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.souborToolStripMenuItem.Text = "Soubor";
            // 
            // vlozitToolStripMenuItem
            // 
            this.vlozitToolStripMenuItem.Name = "vlozitToolStripMenuItem";
            this.vlozitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.vlozitToolStripMenuItem.Text = "Vložit";
            // 
            // zavřítToolStripMenuItem
            // 
            this.zavřítToolStripMenuItem.Name = "zavřítToolStripMenuItem";
            this.zavřítToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.zavřítToolStripMenuItem.Text = "Zavřít";
            // 
            // tiskToolStripMenuItem
            // 
            this.tiskToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiskPokladníhoListkuToolStripMenuItem});
            this.tiskToolStripMenuItem.Name = "tiskToolStripMenuItem";
            this.tiskToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.tiskToolStripMenuItem.Text = "Tisk";
            // 
            // tiskPokladníhoListkuToolStripMenuItem
            // 
            this.tiskPokladníhoListkuToolStripMenuItem.Name = "tiskPokladníhoListkuToolStripMenuItem";
            this.tiskPokladníhoListkuToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.tiskPokladníhoListkuToolStripMenuItem.Text = "Tisk pokladního listku";
            // 
            // labelDIC
            // 
            this.labelDIC.AutoSize = true;
            this.labelDIC.Location = new System.Drawing.Point(12, 132);
            this.labelDIC.Name = "labelDIC";
            this.labelDIC.Size = new System.Drawing.Size(28, 13);
            this.labelDIC.TabIndex = 21;
            this.labelDIC.Text = "DIČ:";
            // 
            // textBoxDIC
            // 
            this.textBoxDIC.Location = new System.Drawing.Point(56, 129);
            this.textBoxDIC.Name = "textBoxDIC";
            this.textBoxDIC.Size = new System.Drawing.Size(138, 20);
            this.textBoxDIC.TabIndex = 22;
            // 
            // labelVyplacene
            // 
            this.labelVyplacene.AutoSize = true;
            this.labelVyplacene.Location = new System.Drawing.Point(15, 172);
            this.labelVyplacene.Name = "labelVyplacene";
            this.labelVyplacene.Size = new System.Drawing.Size(86, 13);
            this.labelVyplacene.TabIndex = 23;
            this.labelVyplacene.Text = "Vyplaceno komu";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 169);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(323, 20);
            this.textBox1.TabIndex = 24;
            // 
            // buttonVloz
            // 
            this.buttonVloz.Location = new System.Drawing.Point(515, 214);
            this.buttonVloz.Name = "buttonVloz";
            this.buttonVloz.Size = new System.Drawing.Size(101, 36);
            this.buttonVloz.TabIndex = 25;
            this.buttonVloz.Text = "Vložit";
            this.buttonVloz.UseVisualStyleBackColor = true;
            // 
            // New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 278);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "New";
            this.Text = "NovyZaznam";
            this.Load += new System.EventHandler(this.New_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCislo;
        private System.Windows.Forms.ComboBox comboBoxTypDokladu;
        private System.Windows.Forms.DateTimePicker DatePickerDatumPD;
        private System.Windows.Forms.TextBox textBoxčisloPD;
        private System.Windows.Forms.TextBox textBoxDPH;
        private System.Windows.Forms.TextBox textBoxCenabBDPH;
        private System.Windows.Forms.Label labelCelkem;
        private System.Windows.Forms.Label labelDPH;
        private System.Windows.Forms.Label labelCena;
        private System.Windows.Forms.TextBox textBoxCelemKC;
        private System.Windows.Forms.TextBox textBoxDPHzc;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem souborToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vlozitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zavřítToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiskPokladníhoListkuToolStripMenuItem;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelTypPlatby;
        private System.Windows.Forms.ComboBox comboBoxTypPlatby;
        private System.Windows.Forms.Label labelUcelPlatby;
        private System.Windows.Forms.TextBox textBoxUcelP;
        private System.Windows.Forms.Label labelFirma;
        private System.Windows.Forms.TextBox textBoxFirma;
        private System.Windows.Forms.TextBox textBoxSlovy;
        private System.Windows.Forms.Label labelCenaSlovy;
        private System.Windows.Forms.Button buttonVloz;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelVyplacene;
        private System.Windows.Forms.TextBox textBoxDIC;
        private System.Windows.Forms.Label labelDIC;
    }
}