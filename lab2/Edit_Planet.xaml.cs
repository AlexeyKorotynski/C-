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
    /// Логика взаимодействия для Edit_Planet.xaml
    /// </summary>
    public partial class Edit_Planet : Window
    {
        public Collection tmpcol { get; set; }
        public Edit_Planet(ref Collection col)
        {
            InitializeComponent();
            tmpcol = col;
            PlanetsList.DataContext = tmpcol;
        }
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            Planet_Edit_Window Planet_Edit_Window = new Planet_Edit_Window(tmpcol.Planets[PlanetsList.SelectedIndex]);
            Planet_Edit_Window.Show();
        }
        private void Remove_Planet(object sender, RoutedEventArgs e)
        {
            tmpcol.Planets.Remove(tmpcol.Planets[PlanetsList.SelectedIndex]);
        }
    }
}
