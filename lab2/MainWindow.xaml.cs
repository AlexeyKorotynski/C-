using System.Windows;
using System.Windows.Input;
using System.Windows.Forms;

namespace lab2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Collection col  = new Collection();
        public Collection tmpcol { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            tmpcol = col;
            AsterismsList.DataContext = tmpcol;
            StarsList.DataContext = tmpcol;
            PlanetsList.DataContext = tmpcol;
            Asterism ori = new Asterism();
            ori.Name = "Orion";
            ori.Position = "4h 37m, 11°";
            tmpcol.AddAsterism(ori);

            Planet earth = new Planet();
            earth.Name = "Earth";
            earth.Radius = 1;
            earth.Mass = 1;
            earth.Rotation = 1;
            earth.Star = "Sun";
            earth.Rotation_around = 1;
            earth.Orbit = 1;
            tmpcol.AddPlanet(earth);

            Star sun = new Star();
            sun.Name = "Sun";
            sun.Radius = 1;
            sun.Mass = 1;
            sun.Luminosity = 1;
            sun.Type = "G2V";
            tmpcol.AddStar(sun);
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            AddAster addAster = new AddAster(ref col);
            addAster.Show();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            
            AddSt addStar = new AddSt(ref col);
            addStar.Show();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {

            AddPlanet addPlanet = new AddPlanet(ref col);
            addPlanet.Show();
        }

        private void Edit_Click_1(object sender, RoutedEventArgs e)
        {

            Edit_Asterism edit_Asterism = new Edit_Asterism(ref col);
            edit_Asterism.Show();
        }

        private void Edit_Click_2(object sender, RoutedEventArgs e)
        {

            Edit_Star edit_Star = new Edit_Star(col);
            edit_Star.Show();
        }

        private void Edit_Click_3(object sender, RoutedEventArgs e)
        {

            Edit_Planet edit_Planet = new Edit_Planet(ref col);
            edit_Planet.DataContext = col;
            edit_Planet.Show();
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Copy_Data copy_Data = new Copy_Data(col);
            copy_Data.Show();
            Close();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Copy_Data copy_Data = new Copy_Data(col);
            copy_Data.Show();
        }

        private void Save_Click1(object sender, RoutedEventArgs e)
        {
            col.Save_to_File();
        }

        private void Save_Click2(object sender, RoutedEventArgs e)
        {
            col.SaveToBinaryFile();
        }

        private void Open_Click1(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Text files (*.txt)|*.txt";
            dialog.ShowDialog();
            if (!string.IsNullOrEmpty(dialog.FileName))
                col.LoadfromFile(dialog.FileName);
        }

        private void Open_Click2(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Binary files (*.dat)|*.dat";
            dialog.ShowDialog();
            if(!string.IsNullOrEmpty(dialog.FileName))
                col.LoadFromBinaryFile(dialog.FileName);
        }
    }
}
