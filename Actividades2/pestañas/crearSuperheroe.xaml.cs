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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Actividades2.pestañas
{
    public partial class crearSuperheroe : UserControl
    {
        public crearSuperheroe()
        {
            InitializeComponent();
            heroeRadioButton.IsChecked = true;
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
            mainWindow.Superheroes.Add(Resources["superheroe"] as Superheroe);
            MessageBox.Show("Superhéroe insertado con exito\n" + Resources["superheroe"],
                "Superhéroes", MessageBoxButton.OK, MessageBoxImage.Information);
            limpiar();
        }
    }
}
