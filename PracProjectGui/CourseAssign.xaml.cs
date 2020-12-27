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
    /// Interaction logic for CourseAssign.xaml
    /// </summary>
    public partial class CourseAssign : Window
    {
        BizLogic bl = new BizLogic();
        User user;
        List<Course_Assign> ca;
        List<Course_Assign> ca1;
        public CourseAssign(User user)
        {
            InitializeComponent();
            this.user = user;
            List<String> SL = bl.loadTCombo();
            List<String> SC = bl.loadCCombo();
            this.ComboSelectTeacher.ItemsSource = SL;
            this.ComboSelectCourse.ItemsSource = SC;
        }

        private void ComboSelectCourse_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CAList.SelectedItem = null;
        }

        private void ComboSelectSem_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CAList.SelectedItem = null;
        }

        private void ComboSelectTeacher_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           CAList.SelectedItem = null;
        }

        private void ComboSelectYear_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CAList.SelectedItem = null;
        }

        private void LogOutBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Mw = new MainWindow();
            this.Hide();
            Mw.Show();
        }

        private void HomeBtn_Click(object sender, RoutedEventArgs e)
        {
            Window1 w = new Window1(user);
            this.Hide();
            w.Show();
        }

        private void LoadBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(ComboSelectCourse.Text) || !String.IsNullOrEmpty(ComboSelectTeacher.Text) || !String.IsNullOrEmpty(ComboSelectYear.Text))
            {
                string cnm = this.ComboSelectCourse.Text;
                string tnm = this.ComboSelectTeacher.Text;
                string yr = this.ComboSelectYear.Text;
                //this.CourseName.IsReadOnly = true;
                ca1 = bl.LoadCA(cnm,yr,tnm);
                if(ca1.Count!=0)
                {
                    CAList.ItemsSource = ca1;
                }
                else
                {
                    MessageBox.Show("NO Values Found: Please Either Select Course or Teacher or Year");
                }
                
                /*if (ca.error == null)
                {
                    this.ComboSelectCredit.Text = c.credit;
                    this.DeleteBtn.IsEnabled = true;
                    this.UpdateBtn.IsEnabled = true;
                    this.InsertBtn.IsEnabled = false;
                    this.LoadBtn.IsEnabled = false;
                }
                else
                {
                    MessageBox.Show(c.error);
                    this.DeleteBtn.IsEnabled = false;
                    this.UpdateBtn.IsEnabled = false;
                    this.InsertBtn.IsEnabled = true;
                    this.LoadBtn.IsEnabled = true;

                }*/

            }
            else
            {
                MessageBox.Show("Please Either Select Course or Teacher or Year");
            }
        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            string id = "";
            string cnm = "";
            string tnm = "";
            string yr = "";
            string sem = "";
            var cellInfo = CAList.SelectedItem as Course_Assign;
            if (cellInfo != null)
            {
                id = cellInfo.CaId;
            }
            cnm = ComboSelectCourse.SelectedItem.ToString();
            tnm = ComboSelectTeacher.SelectedItem.ToString();
            yr = ComboSelectYear.Text;
            sem = ComboSelectSem.Text;

            string s = bl.UpdateCA(cnm, tnm, yr, sem, id);
            if (s.Equals("Updated"))
            {
                ComboSelectCourse.SelectedItem = default;
                ComboSelectTeacher.SelectedItem = default;
                ComboSelectYear.SelectedItem = default;
                ComboSelectSem.SelectedItem = default;
                this.DeleteBtn.IsEnabled = false;
                this.UpdateBtn.IsEnabled = false;
                this.InsertBtn.IsEnabled = true;
                this.LoadBtn.IsEnabled = true;
                CAList.ItemsSource = null;
                MessageBox.Show(s);
            }
            else
            {
                MessageBox.Show(s);
            }
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            string id = "";
            var cellInfo = CAList.SelectedItem as Course_Assign;
            if (cellInfo != null)
            {
                id = cellInfo.CaId;
            }
            string s = bl.DeleteCA(id);
            if (s.Equals("Deleted"))
            {
                ComboSelectCourse.SelectedItem = default;
                ComboSelectTeacher.SelectedItem = default;
                ComboSelectYear.SelectedItem = default;
                ComboSelectSem.SelectedItem = default;
                this.DeleteBtn.IsEnabled = false;
                this.UpdateBtn.IsEnabled = false;
                this.InsertBtn.IsEnabled = true;
                this.LoadBtn.IsEnabled = true;
                CAList.ItemsSource = null;
                MessageBox.Show(s);
            }
            else
            {
                MessageBox.Show(s);
            }
        }

        private void InsertBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ComboSelectCourse.SelectedItem != default && ComboSelectSem.SelectedItem!=default && ComboSelectYear.SelectedItem!=default && ComboSelectTeacher.SelectedItem!=default)
            {
                string cname = ComboSelectCourse.Text;
                string tname = ComboSelectTeacher.Text;
                string sem = ComboSelectSem.Text;
                string yr = ComboSelectYear.Text;
                string s = bl.AssignCourse(cname,tname,yr,sem);
                if (s.Equals("Done"))
                {
                    ComboSelectCourse.SelectedItem = default;
                    ComboSelectYear.SelectedItem = default;
                    ComboSelectTeacher.SelectedItem = default;
                    ComboSelectSem.SelectedItem = default;
                    CAList.ItemsSource = null;
                    MessageBox.Show(s);

                }
                else
                {
                    MessageBox.Show(s);
                }

            }
            else
            {
                MessageBox.Show("Required field is empty");
            }
        }
        

        private void CAList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.LoadBtn.IsEnabled = true;
            this.InsertBtn.IsEnabled = true;
            var cellInfo = CAList.SelectedItem as Course_Assign;
            if(cellInfo!=null)
            {
                ComboSelectCourse.SelectedItem = cellInfo.CName;
                ComboSelectYear.Text = cellInfo.Year;
                ComboSelectTeacher.SelectedItem = cellInfo.TName;
                ComboSelectSem.Text = cellInfo.Sem;
            }
            this.DeleteBtn.IsEnabled = true;
            this.UpdateBtn.IsEnabled = true;
        }

        private void btnGetAll_Click(object sender, RoutedEventArgs e)
        {
            ca = bl.getAllCA();
            CAList.ItemsSource = ca;
        }

        private void btncClr_Click(object sender, RoutedEventArgs e)
        {
            ComboSelectCourse.SelectedItem = default;
            ComboSelectYear.SelectedItem = default;
            ComboSelectTeacher.SelectedItem = default;
            ComboSelectSem.SelectedItem = default;
            this.DeleteBtn.IsEnabled = false;
            this.UpdateBtn.IsEnabled = false;
            this.InsertBtn.IsEnabled = true;
            this.LoadBtn.IsEnabled = true;
            CAList.ItemsSource = null;
        }
    }
}