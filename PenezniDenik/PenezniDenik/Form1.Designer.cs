namespace PenezniDenik
{
    partial class Form1
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.buttonSafe = new System.Windows.Forms.Button();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFirstName.Location = new System.Drawing.Point(86, 31);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(89, 18);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "FirstName:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLastName.Location = new System.Drawing.Point(86, 70);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(86, 18);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "LastName:";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAge.Location = new System.Drawing.Point(86, 110);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(40, 18);
            this.labelAge.TabIndex = 3;
            this.labelAge.Text = "Age:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(181, 29);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(309, 20);
            this.textBoxFirstName.TabIndex = 4;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(181, 70);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(309, 20);
            this.textBoxLastName.TabIndex = 5;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(181, 108);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(309, 20);
            this.textBoxAge.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnFirstName,
            this.columnLastName,
            this.columnAge});
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(147, 238);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(293, 198);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // buttonSafe
            // 
            this.buttonSafe.Location = new System.Drawing.Point(367, 178);
            this.buttonSafe.Name = "buttonSafe";
            this.buttonSafe.Size = new System.Drawing.Size(123, 26);
            this.buttonSafe.TabIndex = 8;
            this.buttonSafe.Text = "Safe";
            this.buttonSafe.UseVisualStyleBackColor = true;
            this.buttonSafe.Click += new System.EventHandler(this.buttonSafe_Click);
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 33;
            // 
            // columnFirstName
            // 
            this.columnFirstName.Text = "FirstName";
            this.columnFirstName.Width = 89;
            // 
            // columnLastName
            // 
            this.columnLastName.Text = "LastName";
            this.columnLastName.Width = 79;
            // 
            // columnAge
            // 
            this.columnAge.Text = "Age";
            this.columnAge.Width = 87;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(141, 178);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(131, 25);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "btnUpdate";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(617, 496);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.buttonSafe);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonSafe;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnFirstName;
        private System.Windows.Forms.ColumnHeader columnLastName;
        private System.Windows.Forms.ColumnHeader columnAge;
        private System.Windows.Forms.Button btnUpdate;

    }
}

