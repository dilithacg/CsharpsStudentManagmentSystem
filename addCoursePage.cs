using System.Data.SqlClient;

namespace studentManagementSystem
{
    public partial class addCoursePage : Form
    {
        public addCoursePage()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string connetionString = @"Data Source=LAPTOP-2VPFL9G3;Initial Catalog=studentManagemntSystem;Integrated Security = True;";

            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);

            string quary = "insert into courseTable values('" + textbox1.Text + "','" + textbox2.Text + "')";
            SqlCommand runQuery = new SqlCommand(quary, cnn);
            cnn.Open();
            if (runQuery.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Course Added Successfully");
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }

            cnn.Close();
            this.Close();

        }

        private void addCoursePage_Load(object sender, EventArgs e)
        {

        }
    }
}
