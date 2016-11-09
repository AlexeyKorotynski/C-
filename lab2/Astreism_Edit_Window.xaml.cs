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
    /// Логика взаимодействия для Astreism_Edit_Window.xaml
    /// </summary>
    public partial class Asterism_Edit_Window : Window
    {
        public Asterism_Edit_Window(Asterism tmpAsterism)
        {
            InitializeComponent();
            DataContext = tmpAsterism;
        }
        public Asterism_Edit_Window()
        {
            InitializeComponent();
        }
        Asterism tmpAsterism = new Asterism();
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
