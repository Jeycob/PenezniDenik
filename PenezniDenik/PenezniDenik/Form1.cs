using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;



namespace PenezniDenik
{
    public partial class Form1 : Form
    {
        private Database db;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                       
        }

        private void printButton(object sender, EventArgs e)
        {

            new Graphics.PdfWriter().PrijmovyPokladniDoklad();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dbToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            db = new Database();
            String s = "CREATE TABLE IF NOT EXISTS \"main\".\"friends\" (\"idfriend\" INTEGER, \"firstname\" VARCHAR, \"lastname\" VARCHAR, \"age\" INTEGER)";
            db.GetDataTable(s);

            s = "select * from main.friends;";
            DataTable recipe;
            recipe = db.GetDataTable(s);
            dataGridView1.DataSource = recipe;
        }

     
    }
}
