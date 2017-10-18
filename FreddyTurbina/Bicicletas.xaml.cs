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
using BibliotecaBicicletas;

namespace FreddyTurbina
{
    /// <summary>
    /// Lógica de interacción para Bicicletas.xaml
    /// </summary>
    public partial class Bicicletas : Window
    {
        public Bicicletas()
        {
            InitializeComponent();
            //Posiciona la ventana en el centro de la pantalla
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            init();
        }

        public void init()
        {
            //TextBox
            txtModelo.Text = string.Empty;
            txtCompra.Text = string.Empty;
            txtStock.Text = string.Empty;
            txtVenta.Text = string.Empty;
            //Combobox
            cboMarca.ItemsSource = Enum.GetValues(typeof(EnumBici.Marca));
            cboOrigen.ItemsSource = Enum.GetValues(typeof(EnumBici.Origen));
            //Actualizar los combobox

            //Marcas
            cboMarca.Items.Refresh();
            cboMarca.SelectedIndex = 0;
            //Origen
            cboOrigen.Items.Refresh();
            cboOrigen.SelectedIndex = 0;
        }
    }
}
