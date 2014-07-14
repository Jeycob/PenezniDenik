using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;



namespace PenezniDenik
{
    public partial class Form1 : Form
    {
        private string ConnectionString;

        public Form1()
        {
            InitializeComponent();

            ConnectionString = @"data source = database.db3";
        }

        private void buttonSafe_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection(ConnectionString))
            {
                try
                {
                    SQLiteCommand command = new SQLiteCommand();
                    command.CommandText = @"INSERT INTO User(FirstName, LastName, Age ) VALUES (@FirstName, @LastName, @Age) ";
                    //command.Connection = con;
                    command.Parameters.Add(new SQLiteParameter("@FirstName", textBoxFirstName.Text));
                    command.Parameters.Add(new SQLiteParameter("@LastName", textBoxLastName.Text));
                    command.Parameters.Add(new SQLiteParameter("@Age", textBoxAge.Text));
                    command.Connection = con;
                    con.Open();

                    int i = command.ExecuteNonQuery();

                    if (i == 1)
                    {
                        MessageBox.Show("User created Successfully");
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

        }

            //vypisovani do pdf
            //new Graphics.PdfWriter().PrijmovyPokladniDoklad();
    }
}
