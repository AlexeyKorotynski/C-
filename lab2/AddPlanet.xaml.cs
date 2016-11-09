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
    /// Логика взаимодействия для AddPlanet.xaml
    /// </summary>
    public partial class AddPlanet : Window
    {
        Planet tmpPlanet = new Planet();
        Collection tmpcol;
        public AddPlanet(ref Collection col)
        {
            InitializeComponent();
            this.DataContext = tmpPlanet;
            tmpcol = col;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            tmpcol.AddPlanet(tmpPlanet);
            this.Close();
        }
    }
}
