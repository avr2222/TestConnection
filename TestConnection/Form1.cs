using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace TestConnection
{
    public partial class ConnectionTester : Form
    {
        public ConnectionTester()
        {
            InitializeComponent();
        }

        public string ConnectionTest()
        {
            try
            {
                //Test Git Hub
                using (OracleConnection con = new OracleConnection(txtConnection_string.Text))
                {
                    con.Open();
                    return "Connection Successfull";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        public DataTable ExectueQuery()
        {
            try
            {
                OracleDataAdapter adpt;
                DataTable dataTable;
                using (OracleConnection con = new OracleConnection(txtConnection_string.Text))
                {
                    con.Open();
                    adpt = new OracleDataAdapter(txtQuery.Text, con);
                    dataTable = new DataTable();
                    adpt.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private async void btntest_Click(object sender, EventArgs e)
        {
            lblstatus.Visible = true;
            Task<string> task = new Task<string>(ConnectionTest);
            task.Start();
            lblstatus.Text = "Checking....";
            string status = await task;

            lblstatus.Visible = false;
            MessageBox.Show(status);
           
        }

      
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnExecute_Click(object sender, EventArgs e)
        {
            try
            {
                lblstatus.Visible = true;
                Task<DataTable> Executetask = new Task<DataTable>(ExectueQuery);
                Executetask.Start();
                lblstatus.Text = "Executing....";
                DataTable dataTable = await Executetask;
                dataGridView1.DataSource = dataTable;

                lblstatus.Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void ConnectionTester_Load(object sender, EventArgs e)
        {

        }
    }
}
