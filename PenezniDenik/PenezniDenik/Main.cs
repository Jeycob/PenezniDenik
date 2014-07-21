using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;



namespace PenezniDenik
{
    public partial class Main : Form
    {
        private string ConnectionString;
        public DataGridView dgv { get { return this.dataGridView1; } }

        public Main()
        {
            InitializeComponent();
            ConnectionString = @"data source = database.db3";
            Database.GetInstance(this).Refresh();

        }

        //using (SQLiteConnection con = new SQLiteConnection(ConnectionString))
        //{
        //    try
        //    {
        //        SQLiteCommand command = new SQLiteCommand();
        //        command.CommandText = @"INSERT INTO User(FirstName, LastName, Age ) VALUES (@FirstName, @LastName, @Age) ";
        //        command.Connection = con;
        //        command.Parameters.Add(new SQLiteParameter("@FirstName", textBoxFirstName.Text));
        //        command.Parameters.Add(new SQLiteParameter("@LastName", textBoxLastName.Text));
        //        command.Parameters.Add(new SQLiteParameter("@Age", textBoxAge.Text)); 
        //       // command.Connection = con;
        //        con.Open();

        //        int i = command.ExecuteNonQuery();

        //        if (i == 1)
        //        {
        //            MessageBox.Show("User created Successfully");
        //        }

        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //}
        private void buttonSafe_Click(object sender, EventArgs e)
        {



        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

           
        }
        //new Graphics.PdfWriter().PrijmovyPokladniDoklad();
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void novýZáznamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New n = new New(this);
            n.Show();
        }

        private void uložitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

   
      
       
           
    }
}
