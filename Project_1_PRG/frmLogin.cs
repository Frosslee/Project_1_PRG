using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1_PRG
{
   
    public partial class frmLogin : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;

        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
             cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: 
        \Users\franc\OneDrive - belgiumcampus.ac.za\study\2nd Year\PRG\PRG 282\assignment\Project\Project_1_PRG\Project_1_PRG\Database1.mdf;Integrated Security=True");

            cn.Open();
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtpassword.Text != string.Empty || txtusername.Text != string.Empty)
            {

                 cmd = new SqlCommand("select * from LoginTable where username='" + txtusername.Text + "' and password='" + txtpassword.Text + "'", cn);
               var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    frmMenu home = new frmMenu();
                    home.ShowDialog();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void brnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Regestration registration = new Regestration();
            registration.ShowDialog();
        }

      
    }
}

/*
SqlConnection con = new SqlConnection(@"Data Source=USER;Initial Catalog=admin;Integrated Security=True"); // making connection   
SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM login WHERE username='" + textBox1.Text + "' AND password='" + textBox2.Text + "'", con);

// in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. 
DataTable dt = new DataTable(); //this is creating a virtual table  
sda.Fill(dt);
if (dt.Rows[0][0].ToString() == "1")
{
    // I have made a new page called home page. If the user is successfully authenticated then the form will be moved to the next form 
    this.Hide();
    new home().Show();
}
else
    MessageBox.Show("Invalid username or password");
*/