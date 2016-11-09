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

namespace lab2
{
    /// <summary>
    /// Логика взаимодействия для Planet_Edit_Window.xaml
    /// </summary>
    public partial class Planet_Edit_Window : Window
    {
        public Planet_Edit_Window(Planet tmpPlanet)
        {
            InitializeComponent();
            this.DataContext = tmpPlanet;
        }
        public Planet_Edit_Window()
        {
            InitializeComponent();
        }
        private void ESaveButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
