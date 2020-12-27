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
    /// Interaction logic for AddTeacher.xaml
    /// </summary>
    public partial class AddTeacher : Window
    {
        BizLogic bl = new BizLogic();
        User user = new User();
        //Dal dl = new Dal();
        public AddTeacher(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void TName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TId_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TMail_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TAddress_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TDegree_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LogOutBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Mw = new MainWindow();
            this.Hide();
            Mw.Show();
        }

        private void LoadBtn_Click(object sender, RoutedEventArgs e)
        {
            if(this.TId.Text!=null && this.TId.Text !="")
            {
                string id = this.TId.Text;
                this.TId.IsReadOnly = true;
                Teacher t = bl.LoadTeacher(id);
                if (t.error == null)
                {
                    this.TAddress.AppendText(t.tAddress);
                    this.TDegree.AppendText(t.tDegree);
                    this.TMail.AppendText(t.tEmail);
                    this.TName.AppendText(t.tName);
                    this.DeleteBtn.IsEnabled = true;
                    this.UpdateBtn.IsEnabled = true;
                    this.InsertBtn.IsEnabled = false;
                    this.LoadBtn.IsEnabled = false;
                }
                else
                {
                    MessageBox.Show(t.error);
                    this.DeleteBtn.IsEnabled = true;
                    this.UpdateBtn.IsEnabled = true;
                    this.InsertBtn.IsEnabled = false;
                    this.TId.IsReadOnly = false;
                }

            }
            else
            {
                MessageBox.Show("ID Field is Empty");
            }
        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            if (TId.Text != "" && TName.Text != "" && TAddress.Text != "" && TMail.Text != "" && TDegree.Text != "")
            {
                string id = TId.Text;
                string name = TName.Text;
                string add = TAddress.Text;
                string mail = TMail.Text;
                string deg = TDegree.Text;
                string s = bl.UpdateTeacher(id, name, add, mail, deg);
                if (s.Equals("Updated"))
                {
                    TId.Text = "";
                    TName.Text = "";
                    TAddress.Text = "";
                    TMail.Text = "";
                    TDegree.Text = "";
                    this.DeleteBtn.IsEnabled = false;
                    this.UpdateBtn.IsEnabled = false;
                    this.InsertBtn.IsEnabled = true;
                    this.LoadBtn.IsEnabled = true;
                    this.TId.IsReadOnly = false;
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
            string id = TId.Text;
            string s = bl.DeleteTeacher(id);
            if (s.Equals("Deleted"))
            {
                TId.Text = "";
                TName.Text = "";
                TAddress.Text = "";
                TMail.Text = "";
                TDegree.Text = "";
                this.DeleteBtn.IsEnabled = false;
                this.UpdateBtn.IsEnabled = false;
                this.InsertBtn.IsEnabled = true;
                this.TId.IsReadOnly = false;
                MessageBox.Show(s);
            }
            else
            {
                MessageBox.Show(s);
            }
        }

        private void InsertBtn_Click(object sender, RoutedEventArgs e)
        {
            if(TId.Text!="" && TName.Text!="" && TAddress.Text!="" && TMail.Text!="" && TDegree.Text!="")
            {
                string id = TId.Text;
                string name = TName.Text;
                string add = TAddress.Text;
                string mail = TMail.Text;
                string degree = TDegree.Text;
                string s=bl.InsertTeacher(id,name,add,mail,degree);
                if(s.Equals("Done"))
                {
                    TId.Text = "";
                    TName.Text = "";
                    TAddress.Text = "";
                    TMail.Text = "";
                    TDegree.Text = "";
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
            this.Hide();
            w.Show();
        }

        private void btncClr_Click(object sender, RoutedEventArgs e)
        {
            TId.Text = "";
            TName.Text = "";
            TAddress.Text = "";
            TMail.Text = "";
            TDegree.Text = "";
            this.DeleteBtn.IsEnabled = false;
            this.UpdateBtn.IsEnabled = false;
            this.InsertBtn.IsEnabled = true;
            this.LoadBtn.IsEnabled = true;
            this.TId.IsReadOnly = false;
        }
    }
}
