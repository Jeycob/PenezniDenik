namespace PenezniDenik
{
    partial class Main
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.souborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novýZáznamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zavřítToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databazeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nováToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otevřítToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uložitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zálohovatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upravitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dPHTabulkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiskPokladníhoLístkuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiskPeněžníhoDeníkuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(965, 482);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 506);
            this.panel1.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.souborToolStripMenuItem,
            this.databazeToolStripMenuItem,
            this.tiskToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(965, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // souborToolStripMenuItem
            // 
            this.souborToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novýZáznamToolStripMenuItem,
            this.zavřítToolStripMenuItem});
            this.souborToolStripMenuItem.Name = "souborToolStripMenuItem";
            this.souborToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.souborToolStripMenuItem.Text = "Soubor";
            // 
            // novýZáznamToolStripMenuItem
            // 
            this.novýZáznamToolStripMenuItem.Name = "novýZáznamToolStripMenuItem";
            this.novýZáznamToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.novýZáznamToolStripMenuItem.Text = "Nový záznam";
            this.novýZáznamToolStripMenuItem.Click += new System.EventHandler(this.novýZáznamToolStripMenuItem_Click);
            // 
            // zavřítToolStripMenuItem
            // 
            this.zavřítToolStripMenuItem.Name = "zavřítToolStripMenuItem";
            this.zavřítToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.zavřítToolStripMenuItem.Text = "Zavřít";
            // 
            // databazeToolStripMenuItem
            // 
            this.databazeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nováToolStripMenuItem,
            this.otevřítToolStripMenuItem,
            this.uložitToolStripMenuItem,
            this.zálohovatToolStripMenuItem,
            this.upravitToolStripMenuItem,
            this.dPHTabulkaToolStripMenuItem});
            this.databazeToolStripMenuItem.Name = "databazeToolStripMenuItem";
            this.databazeToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.databazeToolStripMenuItem.Text = "Databáze";
            // 
            // nováToolStripMenuItem
            // 
            this.nováToolStripMenuItem.Name = "nováToolStripMenuItem";
            this.nováToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nováToolStripMenuItem.Text = "Nová";
            // 
            // otevřítToolStripMenuItem
            // 
            this.otevřítToolStripMenuItem.Name = "otevřítToolStripMenuItem";
            this.otevřítToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.otevřítToolStripMenuItem.Text = "Otevřít";
            // 
            // uložitToolStripMenuItem
            // 
            this.uložitToolStripMenuItem.Name = "uložitToolStripMenuItem";
            this.uložitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.uložitToolStripMenuItem.Text = "Uložit";
            this.uložitToolStripMenuItem.Click += new System.EventHandler(this.uložitToolStripMenuItem_Click);
            // 
            // zálohovatToolStripMenuItem
            // 
            this.zálohovatToolStripMenuItem.Name = "zálohovatToolStripMenuItem";
            this.zálohovatToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.zálohovatToolStripMenuItem.Text = "Zálohovat";
            // 
            // upravitToolStripMenuItem
            // 
            this.upravitToolStripMenuItem.Name = "upravitToolStripMenuItem";
            this.upravitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.upravitToolStripMenuItem.Text = "Upravit";
            // 
            // dPHTabulkaToolStripMenuItem
            // 
            this.dPHTabulkaToolStripMenuItem.Name = "dPHTabulkaToolStripMenuItem";
            this.dPHTabulkaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dPHTabulkaToolStripMenuItem.Text = "DPH tabulka";
            // 
            // tiskToolStripMenuItem
            // 
            this.tiskToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiskPokladníhoLístkuToolStripMenuItem,
            this.tiskPeněžníhoDeníkuToolStripMenuItem});
            this.tiskToolStripMenuItem.Name = "tiskToolStripMenuItem";
            this.tiskToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.tiskToolStripMenuItem.Text = "Tisk";
            // 
            // tiskPokladníhoLístkuToolStripMenuItem
            // 
            this.tiskPokladníhoLístkuToolStripMenuItem.Name = "tiskPokladníhoLístkuToolStripMenuItem";
            this.tiskPokladníhoLístkuToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.tiskPokladníhoLístkuToolStripMenuItem.Text = "Tisk pokladního lístku";
            // 
            // tiskPeněžníhoDeníkuToolStripMenuItem
            // 
            this.tiskPeněžníhoDeníkuToolStripMenuItem.Name = "tiskPeněžníhoDeníkuToolStripMenuItem";
            this.tiskPeněžníhoDeníkuToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.tiskPeněžníhoDeníkuToolStripMenuItem.Text = "Tisk peněžního deníku";
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(965, 506);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem souborToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zavřítToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databazeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nováToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zálohovatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upravitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dPHTabulkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novýZáznamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiskPokladníhoLístkuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiskPeněžníhoDeníkuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otevřítToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uložitToolStripMenuItem;

    }

}

