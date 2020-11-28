using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Actividades2.pestañas
{
    public partial class superheroes : UserControl
    {
        private int Posicion { get; set; }

        private int SuperHeroesLength
        {
            get
            {
                return Superheroes.Count;
            }
        }

        private List<Superheroe> Superheroes { get; set; }

        private Image LogoXmen { get; set; }
        
        private Image LogoVengadores { get; set; }

        public superheroes()
        {
            InitializeComponent();
            Posicion = 0;
            Superheroes = (System.Windows.Application.Current.MainWindow as MainWindow).Superheroes;

            generaLogos();
            muestraHeroe(Posicion);
        }

        private void generaLogos()
        {
            Image vengadores = new Image
            {
                Style = Resources["imagenAvengers"] as Style
            };

            Image xmen = new Image
            {
                Style = Resources["imagenXmen"] as Style
            };

            LogoVengadores = vengadores;
            LogoXmen = xmen;
        }

        private void muestraHeroe(int posicion)
        {
            Superheroe superheroe = Superheroes[posicion];

            nombreHeroe.Text = superheroe.Nombre;
            contadorImagen.Text = $"{posicion + 1}/{SuperHeroesLength}";
            imagen.Source = superheroe.Imagen != null ? new ImageSourceConverter().ConvertFromString(superheroe.Imagen) as ImageSource : null;
            contenedorPrincipal.Background = superheroe.Heroe ? Brushes.PaleGreen : Brushes.IndianRed;

            if (superheroe.Vengador)
                logosHeroe.Children.Add(LogoVengadores);
            else
                logosHeroe.Children.Remove(LogoVengadores);
            if (superheroe.Xmen)
                logosHeroe.Children.Add(LogoXmen);
            else
                logosHeroe.Children.Remove(LogoXmen);
        }
        
        private void Izquierda_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            // Si no estamos en la primera posición, pasa al anterior
            if (Posicion > 0)
            {
                Posicion--;
                muestraHeroe(Posicion);
            }   
        }

        private void Derecha_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            // Si no estamos en la última posición, pasa a la siguiente
            if (Posicion < SuperHeroesLength - 1)
            {
                Posicion++;
                muestraHeroe(Posicion);
            }
        }
    }
}
