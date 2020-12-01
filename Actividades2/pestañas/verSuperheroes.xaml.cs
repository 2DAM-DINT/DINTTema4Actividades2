using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Input;

namespace Actividades2.pestañas
{
    public partial class VerSuperheroes : UserControl
    {
        private List<Superheroe> Superheroes { get; set; }

        private int Posicion { get; set; }

        private int SuperHeroesLength
        {
            get
            {
                return Superheroes.Count;
            }
        }

        public VerSuperheroes()
        {
            InitializeComponent();
            Posicion = 0;
            Superheroes = (System.Windows.Application.Current.MainWindow as MainWindow).Superheroes;

            MuestraHeroe();
        }

        public void MuestraHeroe()
        {
            contenedorPrincipal.DataContext = Superheroes[Posicion];

            contadorImagen.Text = $"{Posicion + 1}/{SuperHeroesLength}";
        }
        
        private void Izquierda_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            // Si no estamos en la primera posición, pasa al anterior
            if (Posicion > 0)
            {
                Posicion--;
                MuestraHeroe();
            }   
        }

        private void Derecha_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            // Si no estamos en la última posición, pasa a la siguiente
            if (Posicion < SuperHeroesLength - 1)
            {
                Posicion++;
                MuestraHeroe();
            }
        }
    }
}
