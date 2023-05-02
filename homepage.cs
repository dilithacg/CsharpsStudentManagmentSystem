using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentManagementSystem
{
    public partial class homepage : Form
    {
        public homepage()
        {
            InitializeComponent();
        }

        private void homepage_Load(object sender, EventArgs e)
        {
            this.Show();
        }

        private void homePageManageCourses_Click(object sender, EventArgs e)
        {
           
            addCoursePage addCourseInstance = new addCoursePage();
            addCourseInstance.Show();
        }

        private void homePageManageStudent_Click(object sender, EventArgs e)
        {
            manageStudent manageStudentInstance = new manageStudent();
            manageStudentInstance.Show();
        }

        private void homePagePayments_Click(object sender, EventArgs e)
        {
            managePaymentStudent managePaymentStudentInstance = new managePaymentStudent();
            managePaymentStudentInstance.Show();
        }
    }
}
