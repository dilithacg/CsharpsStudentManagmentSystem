using System.Data.SqlClient;

namespace studentManagementSystem
{
    public partial class addStudent : Form
    {
        
        public addStudent()
        {
            InitializeComponent();
            
        }
        char radioButtonInput;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void addStudent_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if ((radioButton1.Checked || radioButton2.Checked) && (textBox1.Text != "") && (textBox2.Text != "" )&& (textBox3.Text != "") && dateTimePicker1.Checked == true)
            {
                if (radioButton1.Checked)
                {
                    radioButtonInput = 'M';
                }
                else if (radioButton2.Checked)
                {
                    radioButtonInput = 'F';
                }

                DateTime dateAndTime = dateTimePicker1.Value;
                String dateAndTimeInstance = dateAndTime.ToString("yyyy/MM/dd");



                string connetionString = @"Data Source=LAPTOP-2VPFL9G3;Initial Catalog=studentManagemntSystem;Integrated Security = True;";

                SqlConnection cnn;
                cnn = new SqlConnection(connetionString);

                string quary = "insert into studentTable values(" + textBox1.Text + ", '" + textBox2.Text + "', '" + dateAndTimeInstance + "', '" + radioButtonInput + "', " + textBox3.Text + ", '" + listBox1.Text + "');";

                SqlCommand runQuery = new SqlCommand(quary, cnn);
                cnn.Open();
                if (runQuery.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Student added successfully");
                }
                else
                {
                    MessageBox.Show("Something went wrong");
                }

                cnn.Close();
            
            } else
            {
                
                MessageBox.Show("Please complete all the fields");
            
            }

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
    }
}
