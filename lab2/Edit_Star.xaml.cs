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
    /// Логика взаимодействия для Edit_Star.xaml
    /// </summary>
    public partial class Edit_Star : Window
    {
        public Collection tmpcol { get; set; }
        public Edit_Star(Collection col)
        {
            InitializeComponent();
            tmpcol = col;
            StarsList.DataContext = tmpcol;
        }
        private void StarList_MouseDoubleClick(object sender, RoutedEventArgs e)
        {
            Star_Edit_Window Star_Edit_Window = new Star_Edit_Window(tmpcol.Stars[StarsList.SelectedIndex]);
            Star_Edit_Window.Show();
        }

        private void Remove_Star(object sender, RoutedEventArgs e)
        {
            tmpcol.Stars.Remove(tmpcol.Stars[StarsList.SelectedIndex]);
        }
    }
}
