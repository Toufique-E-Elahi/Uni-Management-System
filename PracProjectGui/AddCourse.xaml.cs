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
    /// Interaction logic for AddCourse.xaml
    /// </summary>
    public partial class AddCourse : Window
    {
        BizLogic bl = new BizLogic();
        User user;
        string i = "";
        public AddCourse(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void HomeBtn_Click(object sender, RoutedEventArgs e)
        {
            Window1 w = new Window1(user);
            this.Close();
            w.Show();
        }

        private void LogOutBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Mw = new MainWindow();
            this.Close();
            Mw.Show();
        }

        private void LoadBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(CourseName.Text))
            {
                string name = this.CourseName.Text;
                //this.CourseName.IsReadOnly = true;
                Course c = bl.LoadCourse(name);
                if (c.error == null)
                {
                    this.CourseName.Text = c.cName;
                    i = c.cName;
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
                    
                }

            }
            else
            {
                MessageBox.Show("Name Field is Empty");
            }
        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(CourseName.Text) && ComboSelectCredit.SelectedItem != default)
            {
                
                string name = CourseName.Text;
                string cred = ComboSelectCredit.Text;
                string s = bl.UpdateCourse(name, cred, i);
                if (s.Equals("Updated"))
                {
                    CourseName.Text = "";
                    ComboSelectCredit.SelectedItem = default;
                    MessageBox.Show(s);
                    this.DeleteBtn.IsEnabled = false;
                    this.UpdateBtn.IsEnabled = false;
                    this.InsertBtn.IsEnabled = true;
                    this.LoadBtn.IsEnabled = true;
                }
                else
                {
                    MessageBox.Show(s);
                    this.DeleteBtn.IsEnabled = false;
                    this.UpdateBtn.IsEnabled = false;
                    this.InsertBtn.IsEnabled = true;
                    this.LoadBtn.IsEnabled = true;
                }

            }
            else
            {
                MessageBox.Show("Required field is empty");
            }
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            string name = CourseName.Text;
            string s = bl.DeleteCourse(name);
            if (s.Equals("Deleted"))
            {
                CourseName.Text = "";
                ComboSelectCredit.SelectedItem = default;
                this.DeleteBtn.IsEnabled = false;
                this.UpdateBtn.IsEnabled = false;
                this.InsertBtn.IsEnabled = true;
                this.LoadBtn.IsEnabled = true;
                MessageBox.Show(s);
            }
            else
            {
                MessageBox.Show(s);
            }
        }

        private void InsertBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(CourseName.Text)  && ComboSelectCredit.SelectedItem!=default)
            {
                
                string name = CourseName.Text;
                string cred = ComboSelectCredit.Text;
                
                string s = bl.InsertCourse(name, cred);
                if (s.Equals("Done"))
                {
                    
                    CourseName.Text = "";
                    ComboSelectCredit.SelectedItem = default;
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
        private void ComboSelectCredit_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CourseName_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void btncClr_Click(object sender, RoutedEventArgs e)
        {
            CourseName.Text = "";
            ComboSelectCredit.SelectedItem = default;
            this.DeleteBtn.IsEnabled = false;
            this.UpdateBtn.IsEnabled = false;
            this.InsertBtn.IsEnabled = true;
            this.LoadBtn.IsEnabled = true;
        }
    }
}
