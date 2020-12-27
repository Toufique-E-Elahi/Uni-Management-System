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
    /// Interaction logic for AddAdmin.xaml
    /// </summary>
    public partial class AddAdmin : Window
    {
        BizLogic bl = new BizLogic();
        User user = new User();
        public AddAdmin(User user)
        {
            InitializeComponent();
            this.user = user;
            txtPasswd.PasswordChar = '*';
            txtPasswd.MaxLength = 12;
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            Window1 w = new Window1(user);
            this.Hide();
            w.Show();
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Mw = new MainWindow();
            this.Hide();
            Mw.Show();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void showPass_Unchecked(object sender, RoutedEventArgs e)
        {
            txtPasswdHidden.Visibility = Visibility.Hidden;
            txtPasswd.Visibility = Visibility.Visible;
            txtPasswd.Password = txtPasswdHidden.Text;
        }

        private void showPass_Checked(object sender, RoutedEventArgs e)
        {
            txtPasswdHidden.Visibility = Visibility.Visible;
            txtPasswd.Visibility = Visibility.Hidden;
            txtPasswdHidden.Text = txtPasswd.Password;
        }

        private void txtPasswd_PasswordChanged(object sender, RoutedEventArgs e)
        {

        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            if (txtUser.Text != "" && txtPasswd.Password != "")
            {
                string id = txtUser.Text;
                string pass = txtPasswd.Password;
                string type = combouserType.SelectedItem.ToString();
                string s = bl.InsertUser(id, pass,type);
                if (s.Equals("User Creation Completed"))
                {
                    txtUser.Text = "";
                    txtPasswd.Password = "";
                    combouserType.SelectedItem = default;

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

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrEmpty(txtUser.Text))
            {
                string id = txtUser.Text;
                string s = bl.DeleteUser(id);
                if (s.Equals("Deleted"))
                {
                    txtUser.Text = "";
                    txtPasswd.Password = "";
                    combouserType.SelectedItem = default;
                    MessageBox.Show(s);
                }
                else
                {
                    MessageBox.Show(s);
                }
            }
            else
            {
                MessageBox.Show("User name Field is empty");
            }
        }
    }
}
