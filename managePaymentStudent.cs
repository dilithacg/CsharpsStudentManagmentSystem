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



namespace studentManagementSystem
{
    
    public partial class managePaymentStudent : Form
    {
        
        public managePaymentStudent()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            addStudent addStudentInstance = new addStudent();
            addStudentInstance.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            string connetionString = @"Data Source=LAPTOP-2VPFL9G3;Initial Catalog=studentManagemntSystem;Integrated Security = True;";

            SqlConnection cnn;

            cnn = new SqlConnection(connetionString);

            cnn.Open();

            SqlCommand cmd;
            SqlDataReader dataReader;
            string sql, output = "";

            
         

            
            string stm = "SELECT COUNT(*) FROM studentTable WHERE registrationNumber=" + manageStudent.setValueRegistrationNumber + ";";
            SqlCommand command = new SqlCommand(stm, cnn);
            Int32 count = Convert.ToInt32(command.ExecuteScalar());
            if (count > 0)
            {
                managePayments managePaymentsInstance = new managePayments();
                managePaymentsInstance.Show();
                cnn.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("No student found");
                cnn.Close();
                
            }

            
            



        }
            
        private void manageStudent_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            manageStudent.setValueRegistrationNumber = textBox2.Text;
            button1.Enabled = true;
        }
    }
}
