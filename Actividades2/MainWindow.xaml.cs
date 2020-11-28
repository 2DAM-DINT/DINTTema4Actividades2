using System.Collections.Generic;
using System.Windows;

namespace Actividades2
{
    public partial class MainWindow : Window
    {
        public List<Superheroe> Superheroes { get; set; }

        public MainWindow()
        {
            Superheroes = Superheroe.GetSamples();
            InitializeComponent();
        }
    }
}
