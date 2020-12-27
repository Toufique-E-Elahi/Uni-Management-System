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
    /// Interaction logic for Setting.xaml
    /// </summary>
    public partial class Setting : Window
    {
        User u;
        BizLogic bl = new BizLogic();
        public Setting(User u)
        {
            InitializeComponent();
            passNew.PasswordChar = '*';
            passOld.PasswordChar = '*';
            passOld.MaxLength = 12;
            passNew.MaxLength = 12;
            this.u = u;
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Mw = new MainWindow();
            this.Hide();
            Mw.Show();
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            Window1 w = new Window1(u);
            this.Hide();
            w.Show();
        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            if(!String.IsNullOrEmpty(passOld.Password) && !String.IsNullOrEmpty(passNew.Password))
            {
                string id = u.uId;
                string pass = passOld.Password;
                string password = passNew.Password;
                User user = bl.CheckLogin(id, pass);
                if (user.error == null)
                {
                    string s = bl.UpdatePass(id, password);
                    if (s.Equals("Updated"))
                    {
                        MessageBox.Show("Password Changed Succesfully");
                        passNew.Password = "";
                        passOld.Password = "";

                    }
                    else
                    {
                        MessageBox.Show(s);
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Password");
                    //user.error = null;
                }
            }
            else
            {
                MessageBox.Show("Required field is empty ");
            }

        }

        private void passNew_PasswordChanged(object sender, RoutedEventArgs e)
        {

        }
        private void showPass_Unchecked(object sender, RoutedEventArgs e)
        {
            txtPasswdHidden.Visibility = Visibility.Hidden;
            passNew.Visibility = Visibility.Visible;
            passNew.Password = txtPasswdHidden.Text;
        }

        private void showPass_Checked(object sender, RoutedEventArgs e)
        {
            txtPasswdHidden.Visibility = Visibility.Visible;
            passNew.Visibility = Visibility.Hidden;
            txtPasswdHidden.Text = passNew.Password;
        }

        private void passOld_PasswordChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
