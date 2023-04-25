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

namespace proyectoOnBreak
{
    /// <summary>
    /// Lógica de interacción para Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }
        private List<string> lista = new List<string>(); 

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // Agrega algunos elementos a la lista
            lista.Add("123456789 GreenPeace Ramiro Nemesio ramiro@gmail.com Los Ramiros 12345 12345678 Chilex Rotary Mineria");
            lista.Add("123456780 Global66   Eustacio Valdi eustacio@mail.com Villa Eustacio 1 12341234 Finanzas Global 666");
            lista.Add("123456781 TechCorpo  Rani Yawazaki  kawaiigirl@mail.com Ueno Street 12 98765432 Kawaii Sega Japan 12");

            // Asigna la lista al ListView
            lvListaContrato.ItemsSource = lista;

            // Muestra el ListView
            lvListaContrato.Visibility = Visibility.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Cerrar la ventana actual
            this.Close();

            // Mostrar la ventana principal
            Application.Current.MainWindow.Show();
        }
    }
}
