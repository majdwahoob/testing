using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace admin_page
{
    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F7CTSK1\SQLEXPRESS;Initial Catalog=stock_market;Integrated Security=True;");
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stock_marketDataSet4.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter3.Fill(this.stock_marketDataSet4.users);
            // TODO: This line of code loads data into the 'stock_marketDataSet3.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter2.Fill(this.stock_marketDataSet3.users);
            // TODO: This line of code loads data into the 'stock_marketDataSet2.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter1.Fill(this.stock_marketDataSet2.users);
            // TODO: This line of code loads data into the 'stock_marketDataSet1.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.stock_marketDataSet1.users);
            // TODO: This line of code loads data into the 'stock_marketDataSet.stocks' table. You can move, or remove it, as needed.
            this.stocksTableAdapter.Fill(this.stock_marketDataSet.stocks);
        }
    }
}
