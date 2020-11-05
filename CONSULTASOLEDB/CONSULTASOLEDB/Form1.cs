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
namespace CONSULTASOLEDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            OleDbConnection con = new OleDbConnection(@"Data Source=localhost;Initial Catalog=store;Integrated Security=True");
            OleDbCommand cmd = new OleDbCommand("select * from producto", con);
            OleDbDataAdapter sda = new OleDbDataAdapter(cmd);
            DataTable td = new DataTable();
            sda.Fill(td);
            //DataGridView= td;

        }
        //private void Form_Load(object sender, EventArgs e)
        //{
        //    OleDbConnection con = new OleDbConnection(@"Data Source=localhost;Initial Catalog=store;Integrated Security=True");
        //    OleDbCommand cmd = new OleDbCommand("select * from producto",con);
        //    OleDbDataAdapter sda = new OleDbDataAdapter(cmd);
        //    DataTable td = new DataTable();
        //    sda.Fill(td);
        //  //  DataGridView1.DataSource = td;

        //}
    }
}
