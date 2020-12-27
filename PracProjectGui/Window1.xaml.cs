using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PracProjectGui
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        User user;
        public Window1(User u)
        {
            InitializeComponent();
            this.user = u;
        }

        private void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MW = new MainWindow();
            this.Hide();
            MW.Show();
        }

        private void btnSetting_Click(object sender, RoutedEventArgs e)
        {
            Setting s = new Setting(user);
            this.Hide();
            s.Show();
        }

        private void btnAddTeacher_Click(object sender, RoutedEventArgs e)
        {
            AddTeacher at = new AddTeacher(user);
            this.Hide();
            at.Show();
        }

        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            AddStudent at = new AddStudent(user);
            this.Hide();
            at.Show();
        }

        private void btnAddCourse_Click(object sender, RoutedEventArgs e)
        {
            AddCourse at = new AddCourse(user);
            this.Hide();
            at.Show();
        }

        private void btnStudentList_Click(object sender, RoutedEventArgs e)
        {
            StudentList sl = new StudentList(user);
            this.Hide();
            sl.Show();
        }

        private void btnAssignCourse_Click(object sender, RoutedEventArgs e)
        {
            CourseAssign at = new CourseAssign(user);
            this.Hide();
            at.Show();
        }

        private void btnAddAdmin_Click(object sender, RoutedEventArgs e)
        {
            AddAdmin ad = new AddAdmin(user);
            this.Hide();
            ad.Show();
        }
    }
}
