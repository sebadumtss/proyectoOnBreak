//using MahApps.Metro.Controls;
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

namespace proyectoOnBreak
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 ventanaWindow1 = new Window1();
            ventanaWindow1.ShowDialog();
        }

        private void BtnLisCli_Click(object sender, RoutedEventArgs e)
        {
            Window2 ventanaWindow2 = new Window2();
            ventanaWindow2.ShowDialog();
        }

        private void BtnAdminCont_Click(object sender, RoutedEventArgs e)
        {
            Window3 ventanaWindow3 = new Window3();
            ventanaWindow3.ShowDialog();
        }

        private void BtnListCont_Click(object sender, RoutedEventArgs e)
        {
            Window4 ventanaWindow4 = new Window4();
            ventanaWindow4.ShowDialog();
        }
    }
}
    

