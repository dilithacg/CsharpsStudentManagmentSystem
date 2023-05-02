using System.Data.SqlClient;

namespace studentManagementSystem
{
    public partial class editStudent : Form
    {
    
        public editStudent()
        {
            InitializeComponent();
            
        }
        char radioButtonInput;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void addStudent_Load(object sender, EventArgs e)
        {
            label10.Text = manageStudent.setValueRegistrationNumber;

            string connetionString = @"Data Source=LAPTOP-2VPFL9G3;Initial Catalog=studentManagemntSystem;Integrated Security = True;";



            SqlConnection cnn;

            cnn = new SqlConnection(connetionString);

            cnn.Open();

            SqlCommand cmd;
            SqlDataReader dataReader;
            string sql, output = "";
            
            sql = "select * from studentTable where registrationNumber = " + manageStudent.setValueRegistrationNumber + ';'; 

            cmd = new SqlCommand(sql, cnn); 
            

            dataReader = cmd.ExecuteReader();
            
            while (dataReader.Read())
            {
                label11.Text = dataReader.GetString(1);

                DateTime dateAndTime = dataReader.GetDateTime(2);
                String dateAndTimeInstance = dateAndTime.ToString("yyyy/MM/dd");
                label12.Text = dateAndTimeInstance;

                DateTime date = dataReader.GetDateTime(2);
                int age = DateTime.Now.Year - date.Year;
                label9.Text = age.ToString();
                
                if (dataReader.GetString(3) == "M")
                {
                    
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                    radioButton2.Enabled = false;
                } else if (dataReader.GetString(3) == "F")
                {  
                    radioButton2.Checked = true;
                    radioButton1.Checked = false;
                    radioButton1.Enabled = false;
                }

                label13.Text = dataReader.GetString(4);
                
                label14.Text = dataReader.GetString(5);
                
            }

            cnn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            editStudentUser editStudentUserInstance = new editStudentUser();
            editStudentUserInstance.Show();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        /*private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1 == null)
            {
                label9.Text = "0";
            }
            else
            {
                int age = DateTime.Now.Year - dateTimePicker1.Value.Year;
                label9.Text = age.ToString();

                if (age < 18)
                {
                    MessageBox.Show("Cannot enroll - Below 18 Years");
                    dateTimePicker1.Value = default(DateTime);

                }
            }
        }*/

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {


            string connetionString = @"Data Source=LAPTOP-2VPFL9G3;Initial Catalog=studentManagemntSystem;Integrated Security = True;";


            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);



            string quary = "DELETE FROM studentTable where registrationNumber = " + manageStudent.setValueRegistrationNumber + ";";

            SqlCommand runQuery = new SqlCommand(quary, cnn);

            cnn.Open();

             
            
    
            


            if (MessageBox.Show("Confirm delete student", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {



                if (runQuery.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Student deleted successfully");
                }
                else
                {
                    MessageBox.Show("Something went wrong");
                }
            } else
            {
                this.Close();
            }

            cnn.Close();
            this.Close();
        }
    }
}
