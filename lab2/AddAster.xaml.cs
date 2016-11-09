using lab2;
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
    /// Логика взаимодействия для AddAster.xaml
    /// </summary>
    public partial class AddAster : Window
    {
        Asterism tmpAsterism = new Asterism();
        Collection tmpcol;
        public AddAster(ref Collection col)
        {
            InitializeComponent();
            this.DataContext = tmpAsterism;
            tmpcol = col;
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            tmpcol.AddAsterism(tmpAsterism);
            this.Close();
        }
    }
}
