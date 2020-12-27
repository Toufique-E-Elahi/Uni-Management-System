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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PracProjectGui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        BizLogic bl = new BizLogic();
        //Dal dl = new Dal();
        public MainWindow()
        {
            InitializeComponent();
            txtPasswd.PasswordChar = '*';
            txtPasswd.MaxLength = 12;
        }
        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {

            if (!String.IsNullOrEmpty(txtUId.Text))
            {

                string id = txtUId.Text;
                string password = txtPasswd.Password;
                User user = bl.CheckLogin(id, password);
                if (user.error == null)
                {
                    Window1 w = new Window1(user);
                    w.Show();
                    this.Hide();
                    MessageBox.Show("Login Successful");
                }
                else
                {
                    MessageBox.Show(user.error);
                }
            }
            else
            {
                MessageBox.Show("Required field is empty");
            }
        }

        private void txtUId_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtPasswd_PasswordChanged(object sender, RoutedEventArgs e)
        {

        }

        private void showPass_Checked(object sender, RoutedEventArgs e)
        {
            txtPasswdHidden.Visibility = Visibility.Visible;
            txtPasswd.Visibility = Visibility.Hidden;
            txtPasswdHidden.Text = txtPasswd.Password;
        }

        private void showPass_Unchecked(object sender, RoutedEventArgs e)
        {
            txtPasswdHidden.Visibility = Visibility.Hidden;
            txtPasswd.Visibility = Visibility.Visible;
            txtPasswd.Password = txtPasswdHidden.Text;
        }
    }
}
