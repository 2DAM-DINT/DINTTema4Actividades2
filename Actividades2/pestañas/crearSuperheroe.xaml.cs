using System.Windows;
using System.Windows.Controls;

namespace Actividades2.pestañas
{
    public partial class CrearSuperheroe : UserControl
    {
        public Superheroe Superheroe { get; set; }

        public CrearSuperheroe()
        {
            InitializeComponent();
            Superheroe = new Superheroe();
            contenedorPrincipal.DataContext = Superheroe;
        }

        private void limpiar()
        {
            nombreHeroe.Text = "";
            imagenHeroe.Text = "";
            imagenPersonajeNuevo.Source = null;
            heroeRadioButton.IsChecked = true;
            vengadoresCheckBox.IsChecked = false;
            xmenCheckBox.IsChecked = false;
        }

        private void Limpiar_Click(object sender, RoutedEventArgs e)
        {
            limpiar();
        }

        private void Aceptar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = (System.Windows.Application.Current.MainWindow as MainWindow);
            mainWindow.Superheroes.Add(Superheroe);

            MessageBox.Show("Superhéroe insertado con exito",
                            "Superhéroes", MessageBoxButton.OK, 
                            MessageBoxImage.Information);

            limpiar();
        }
    }
}
