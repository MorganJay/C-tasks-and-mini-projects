using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace VisitorManagementSystem
{
    public partial class VisitorMgt : Form
    {
        public VisitorMgt()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=JMORGAN_SCHULPC;Initial Catalog=LogIn;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'visitorLogDataSet.VisitorLog' table. You can move, or remove it, as needed.
            //visitorLogTableAdapter.Fill(this.visitorLogDataSet.VisitorLog);
        }

       private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO VisitorLog(PersonofInterest,ReasonforVisit,VisitorName,PhoneNumber,EmailAddress,DateandTimeofVisit) VALUES " +
                           "('"+personofInterestcomboBox.Text+ "','" + reasonforvisittextBox.Text + "','" + nametextBox.Text + "','" + phonenumbertextBox.Text + "','" + emailtextBox.Text + "','" + dateTimePicker1.Value.ToString("dddd MMMM dd , yyyy ")+"')";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            Displaydata();
        }
        public void Displaydata()
        {
            con.Open();
            string query = "SELECT * FROM VisitorLog";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Displaydata();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            personofInterestcomboBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            reasonforvisittextBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            nametextBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            phonenumbertextBox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            emailtextBox.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[6].Value.ToString());
        }
    }
}
