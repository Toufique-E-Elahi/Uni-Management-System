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
    /// Interaction logic for AddStudent.xaml
    /// </summary>
    public partial class AddStudent : Window
    {
        BizLogic bl = new BizLogic();
        User user = new User();
        //Dal dl = new Dal();
        public AddStudent(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void StdName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void StdId_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LogOutBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Mw = new MainWindow();
            this.Close();
            Mw.Show();
        }

        private void StdMail_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void StdAddress_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void StdSem_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LoadBtn_Click(object sender, RoutedEventArgs e)
        {
            if (this.StdId.Text != null && this.StdId.Text != "")
            {
                string id = StdId.Text;
                this.StdId.IsReadOnly = true;
                Student s= bl.LoadStudent(id);
                if(s.Error==null)
                {
                    StdName.Text = s.SName;
                    StdAddress.Text = s.SAddress;
                    StdMail.Text = s.sEmail;
                    StdSem.Text = s.SAdmit;
                    this.DeleteBtn.IsEnabled = true;
                    this.UpdateBtn.IsEnabled = true;
                    this.InsertBtn.IsEnabled = false;
                    this.LoadBtn.IsEnabled = true;
                }
                else
                {
                    MessageBox.Show(s.Error);
                    this.DeleteBtn.IsEnabled = true;
                    this.UpdateBtn.IsEnabled = true;
                    this.InsertBtn.IsEnabled = false;
                    this.StdId.IsReadOnly = false;
                }
 
            }
            else
            {
                MessageBox.Show("ID Field is Empty");
            }

        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            if (StdId.Text != "" && StdName.Text != "" && StdAddress.Text != "" && StdMail.Text != "" && StdSem.Text != "")
            {
                string id = StdId.Text;
                string name = StdName.Text;
                string add = StdAddress.Text;
                string mail = StdMail.Text;
                string sem = StdSem.Text;
                string s = bl.UpdateStudent(id, name, add, mail, sem);
                if (s.Equals("Updated"))
                {
                    StdId.Text = "";
                    StdName.Text = "";
                    StdAddress.Text = "";
                    StdMail.Text = "";
                    StdSem.Text = "";
                    this.DeleteBtn.IsEnabled = false;
                    this.UpdateBtn.IsEnabled = false;
                    this.InsertBtn.IsEnabled = true;
                    this.LoadBtn.IsEnabled = true;
                    this.StdId.IsReadOnly = false;
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

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            string id = StdId.Text;
            string s = bl.DeleteStudent(id);
            if (s.Equals("Deleted"))
            {
                StdId.Text = "";
                StdName.Text = "";
                StdAddress.Text = "";
                StdMail.Text = "";
                StdSem.Text = "";
                this.DeleteBtn.IsEnabled = false;
                this.UpdateBtn.IsEnabled = false;
                this.InsertBtn.IsEnabled = true;
                this.LoadBtn.IsEnabled = true;           
                this.StdId.IsReadOnly = false;
                MessageBox.Show(s);
            }
            else
            {
                MessageBox.Show(s);
            }
        }

        private void InsertBtn_Click(object sender, RoutedEventArgs e)
        {
            
            if (StdId.Text != "" && StdName.Text != "" && StdAddress.Text != "" && StdMail.Text != "" && StdSem.Text != "")
            {
                string id = StdId.Text;
                string name = StdName.Text;
                string add = StdAddress.Text;
                string mail = StdMail.Text;
                string sem = StdSem.Text;
                string s = bl.InsertStudent(id, name, add, mail, sem);
                if (s.Equals("Done"))
                {
                    StdId.Text = "";
                    StdName.Text = "";
                    StdAddress.Text = "";
                    StdMail.Text = "";
                    StdSem.Text = "";
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

        private void HomeBtn_Click(object sender, RoutedEventArgs e)
        {
            Window1 w = new Window1(user);
            this.Close();
            w.Show();
        }

        private void btncClr_Click(object sender, RoutedEventArgs e)
        {
            StdId.Text = "";
            StdName.Text = "";
            StdAddress.Text = "";
            StdMail.Text = "";
            StdSem.Text = "";
            this.DeleteBtn.IsEnabled = false;
            this.UpdateBtn.IsEnabled = false;
            this.InsertBtn.IsEnabled = true;
            this.LoadBtn.IsEnabled = true;
            this.StdId.IsReadOnly = false;
        }
    }
}
