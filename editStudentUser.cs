using System.Data.SqlClient;

namespace studentManagementSystem
{
    public partial class editStudentUser : Form
    {
    
        public editStudentUser()
        {
            InitializeComponent();
            
        }
        char radioButtonInput;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void addStudent_Load(object sender, EventArgs e)
        {

            this.textBox1.Text = manageStudent.setValueRegistrationNumber;
            this.textBox1.Enabled = false;

            string connetionString = @"Data Source=LAPTOP-2VPFL9G3;Initial Catalog=studentManagemntSystem;Integrated Security = True;";



            SqlConnection cnn;

            cnn = new SqlConnection(connetionString);

            cnn.Open();

            SqlCommand cmd;
            SqlDataReader dataReader;
            string sql, output = "";

            sql = "select * from studentTable where registrationNumber = " + manageStudent.setValueRegistrationNumber + ';' ; 

            cmd = new SqlCommand(sql, cnn);


            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                this.textBox2.Text = dataReader.GetString(1);

                DateTime dateAndTimeInstance = dataReader.GetDateTime(2);
                dateTimePicker1.Value = dateAndTimeInstance;

                DateTime date = dataReader.GetDateTime(2);
                int age = DateTime.Now.Year - date.Year;
                label9.Text = age.ToString();

                if (dataReader.GetString(3) == "M")
                {

                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                   
                }
                else if (dataReader.GetString(3) == "F")
                {
                    radioButton2.Checked = true;
                    radioButton1.Checked = false;
                    
                }

                this.textBox3.Text = dataReader.GetString(4);

                /*                editStudent.listBox1.Select = dataReader.GetString(5);
                */
            }

            cnn.Close();

            this.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                radioButtonInput = 'M';
            }
            else if (radioButton2.Checked)
            {
                radioButtonInput = 'F';
            }




            string connetionString = @"Data Source=LAPTOP-2VPFL9G3;Initial Catalog=studentManagemntSystem;Integrated Security = True;";

            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);

            DateTime dateAndTime = dateTimePicker1.Value;
            String dateAndTimeInstance = dateAndTime.ToString("yyyy-MM-dd");

            string quary = "update studentTable set studentName = '" + textBox2.Text + "', " + "dob = '" + dateAndTimeInstance + "', gender = '" + radioButtonInput + "', contactNumber = " + textBox3.Text + ", coursesEnrolledIn = '" + listBox1.Text + "' where registrationNumber = " + manageStudent.setValueRegistrationNumber + ";";

            SqlCommand runQuery = new SqlCommand(quary, cnn);

            cnn.Open();

            if (runQuery.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Student updated successfully");
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }

            cnn.Close();
            this.Close();
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
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
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
