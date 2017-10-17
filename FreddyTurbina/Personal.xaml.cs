using System.Windows;
using BibliotecaPersonal;
using System;
using System.Collections.Generic;

namespace FreddyTurbina
{
    public partial class Personal : Window
    {
        Usuario usuario = new Usuario();
        List<Usuario> lista = new List<Usuario>();

        public Personal()
        {
            InitializeComponent();
            //Posiciona la ventana en el centro de la pantalla
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.init();
        }

        //Método que inicializa los controles con valores por defecto
        public void init()
        {
            //textBoxs
            txtNombre.Text = string.Empty;
            txtAppaterno.Text = string.Empty;
            txtApmaterno.Text = string.Empty;
            txtRut.Text = string.Empty;
            txtSueldobru.Text = string.Empty;
            txtSueldoliq.Text = string.Empty;
            //DatePicker
            dteNacimiento.SelectedDate = System.DateTime.Today;
            dteContrato.SelectedDate = DateTime.Today;
            //combobox
            //obtiene valores de enum
            cboAfp.ItemsSource = Enum.GetValues(typeof(Enumeradores.AFPS));
            cboIsapre.ItemsSource = Enum.GetValues(typeof(Enumeradores.Isapres));
            cboNacionalidad.ItemsSource = Enum.GetValues(typeof(Enumeradores.Nacionalidades));
            //Actualiza los combobox

            //AFPS
            cboAfp.Items.Refresh();
            cboAfp.SelectedIndex = 0;
            //ISAPRES
            cboIsapre.Items.Refresh();
            cboIsapre.SelectedIndex = 0;
            //Nacionalidades
            cboNacionalidad.Items.Refresh();
            cboNacionalidad.SelectedIndex = 0;
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            string errores = string.Empty;//variable que almacenara los errores
            //Validamos que se ingrese un nombre
            if (txtNombre.Text.Length != 0)
            {
                usuario.Nombre = txtNombre.Text;
            }
            else
            {
                errores += "\n-Debe ingresar un nombre.";
            }

            //Validamo apellido paterno
            if (txtAppaterno.Text.Length != 0)
            {
                usuario.Ap_paterno = txtAppaterno.Text;
            }
            else
            {
                errores += "\n-Debe ingresar apellido paterno.";
            }

            //Validamo apellido materno
            if (txtApmaterno.Text.Length != 0)
            {
                usuario.Ap_materno = txtApmaterno.Text;
            }
            else
            {
                errores += "\n-Debe ingresar apellido paterno.";
            }

            //Validamo apellido paterno
            if (txtAppaterno.Text.Length != 0)
            {
                usuario.Ap_paterno = txtAppaterno.Text;
            }
            else
            {
                errores += "\n-Debe ingresar apellido paterno.";
            }

            //validamos RUT
            if (txtRut.Text.Length == 10)
            {
                usuario.Rut = txtRut.Text;
            }
            else
            {
                errores += "\n-El rut debe tener 10 carácteres. Ejemplo: 12345678-0";
            }

            if((DateTime)dteNacimiento.SelectedDate < DateTime.Now)
            {
                usuario.FechaNacimiento = (DateTime)dteNacimiento.SelectedDate;
            }
            else
            {
                errores += "\n-La fecha no puede ser mayor o igual a la fecha actual.";
            }

            if ((DateTime)dteContrato.SelectedDate <= DateTime.Now)
            {
                usuario.FechaNacimiento = (DateTime)dteNacimiento.SelectedDate;
            }
            else
            {
                errores += "\n-La fecha no puede ser mayor a la fecha actual.";
            }

            if(cboAfp.SelectedIndex != 0)
            {
                usuario.AFP = cboAfp.SelectedIndex.ToString();
            }
            else
            {
                errores += "\n-Debe seleccionar una AFP.";
            }

            if (cboIsapre.SelectedIndex != 0)
            {
                usuario.Isapre = cboIsapre.SelectedIndex.ToString();
            }
            else
            {
                errores += "\n-Debe seleccionar una Isapre.";
            }

            if (cboNacionalidad.SelectedIndex != 0)
            {
                usuario.Nacionalidad = cboNacionalidad.SelectedIndex.ToString();
            }
            else
            {
                errores += "\n-Debe seleccionar una Nacionalidad.";
            }

            usuario.CalcularEdad();

            if(errores.Length == 0)
            {
                lista.Add(usuario);
                dgResultados.ItemsSource = lista;
                dgResultados.Items.Refresh();
                usuario = new Usuario();

                MessageBox.Show("Persona agregada con éxito!!");
            }
            else
            {
                MessageBox.Show("Se presentaros los siguientes errores:\n" + errores);
            }
        }

    }
}
