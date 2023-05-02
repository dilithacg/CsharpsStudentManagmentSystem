using System.Data.SqlClient;

namespace studentManagementSystem
{
    public partial class managePayments : Form
    {

        public managePayments()
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

            IDictionary<string, double> coursePrice = new Dictionary<string, double>();
            coursePrice.Add("HND - COM", 30000.00);
            coursePrice.Add("HND - BM", 35000.00);
            coursePrice.Add("Dip - IT", 27000.00);
            coursePrice.Add("Dip - English", 25000.00);
            coursePrice.Add("Dip - BM", 29000.00);


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
                label5.Text = dataReader.GetString(5);
                string courseFee = dataReader.GetString(5);
                double temp = coursePrice[courseFee];
                string temp1 = temp.ToString();
                label9.Text = temp1;



            }

            cnn.Close();

            button1.Enabled = false;
            label14.Visible = false;




        }

        private void button1_Click(object sender, EventArgs e)
        {

            string connetionString = @"Data Source=LAPTOP-2VPFL9G3;Initial Catalog=studentManagemntSystem;Integrated Security = True;";


            IDictionary<string, double> coursePrice = new Dictionary<string, double>();
            coursePrice.Add("HND - COM", 30000.00);
            coursePrice.Add("HND - BM", 35000.00);
            coursePrice.Add("Dip - IT", 27000.00);
            coursePrice.Add("Dip - English", 25000.00);
            coursePrice.Add("Dip - BM", 29000.00);

            SqlConnection cnn;

            cnn = new SqlConnection(connetionString);

            cnn.Open();

            SqlCommand cmd;
            SqlDataReader dataReader;
            string sql, output = "";

            sql = "select * from studentTable where registrationNumber = " + manageStudent.setValueRegistrationNumber + ';';

            cmd = new SqlCommand(sql, cnn);


            dataReader = cmd.ExecuteReader();

            double temp;

            while (dataReader.Read())
            {
                string courseFee = dataReader.GetString(5);
                temp = coursePrice[courseFee];
                int temp1 = Int32.Parse(textBox1.Text);
                
                  
                double discount = temp / 100 * temp1;
                label14.Text = (temp - discount).ToString();
            }

            cnn.Close();


            textBox1.Enabled = false;
            label14.Visible = true;

            button1.Enabled = false;





        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
    }
}
