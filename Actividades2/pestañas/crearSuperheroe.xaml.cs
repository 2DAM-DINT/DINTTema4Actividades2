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

        private void Limpiar()
        {
            Superheroe.Nombre = "";
            Superheroe.Imagen = "";
            Superheroe.Heroe = true;
            Superheroe.Villano = false;
            Superheroe.Vengador = false;
            Superheroe.Xmen = false;
        }

        private void Limpiar_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void Aceptar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = (System.Windows.Application.Current.MainWindow as MainWindow);
            mainWindow.Superheroes.Add(new Superheroe(Superheroe));
            mainWindow.verSuperheroes.MuestraHeroe();

            MessageBox.Show("Superhéroe insertado con exito",
                            "Superhéroes", MessageBoxButton.OK, 
                            MessageBoxImage.Information);

            Limpiar();
        }
    }
}
