using System;
using System.Collections;
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
using System.Data;

namespace PracProjectGui
{
    /// <summary>
    /// Interaction logic for StudentList.xaml
    /// </summary>
    public partial class StudentList : Window
    {
        BizLogic bl = new BizLogic();
        User user;
        List<Student> st;
        public StudentList(User user)
        {
            InitializeComponent();
            this.user = user;
            st = bl.loadStdList();
        }
        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            Window1 w = new Window1(user);
            this.Close();
            w.Show();
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Mw = new MainWindow();
            this.Close();
            Mw.Show();
        }


        private void Stdlst_Loaded(object sender, RoutedEventArgs e)
        {
            
            Stdlst.ItemsSource = st;
            
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

    }
}
