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

        //Contadores
        byte contarg = 0;
        byte contbra = 0;
        byte contchi = 0;
        byte conturu = 0;
        byte contpara = 0;
        byte contperu = 0;

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

            //Validamos apellido paterno
            if (txtAppaterno.Text.Length != 0)
            {
                usuario.Ap_paterno = txtAppaterno.Text;
            }
            else
            {
                errores += "\n-Debe ingresar apellido paterno.";
            }

            //Validamos apellido materno
            if (txtApmaterno.Text.Length != 0)
            {
                usuario.Ap_materno = txtApmaterno.Text;
            }
            else
            {
                errores += "\n-Debe ingresar apellido paterno.";
            }

            //Validamos apellido paterno
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
            //Evaluar fecha de nacimiento
            if((DateTime)dteNacimiento.SelectedDate < DateTime.Now.Date)
            {
                DateTime nacimiento;
                nacimiento = (DateTime)dteNacimiento.SelectedDate;
                usuario.CalcularEdad(nacimiento);
                usuario.FechaNacimiento = nacimiento.ToString("dd/MM/yyyy");
            }
            else
            {
                errores += "\n-La fecha no puede ser mayor o igual a la fecha actual.";
            }

            //Evaluar fecha de contrato
            if ((DateTime)dteContrato.SelectedDate <= DateTime.Now.Date)
            {
                DateTime contrato;
                contrato = (DateTime)dteContrato.SelectedDate;
                usuario.FechaContrato = contrato.ToString("dd/MM/yyyy");
            }
            else
            {
                errores += "\n-La fecha no puede ser mayor a la fecha actual.";
            }
            //Evaluar AFP
            if(cboAfp.SelectedIndex != 0)
            {
                usuario.AFP = cboAfp.Text;
            }
            else
            {
                errores += "\n-Debe seleccionar una AFP.";
            }
            //Validar  Isapre
            if (cboIsapre.SelectedIndex != 0)
            {
                usuario.Isapre = cboIsapre.Text;
            }
            else
            {
                errores += "\n-Debe seleccionar una Isapre.";
            }
            //Validar Nacionalidad
            if (cboNacionalidad.SelectedIndex != 0)
            {
                usuario.Nacionalidad = cboNacionalidad.Text;
            }
            else
            {
                errores += "\n-Debe seleccionar una Nacionalidad.";
            }

            //Validamos que sea un numero entero
            if (Int32.TryParse(txtSueldobru.Text,out int sueldobru))
            {
                usuario.Sueldo_bru = sueldobru;
            }
            else
            {
                errores += "\n-Debes ingresar un sueldo bruto con valor entero.";
            }
            //Validamos que sea un numero entero
            if (Int32.TryParse(txtSueldoliq.Text, out int sueldoliq))
            {
                usuario.Sueldo_liq = sueldoliq;
            }
            else
            {
                errores += "\n-Debes ingresar un sueldo liquido con valor entero.";
            }

            switch (cboNacionalidad.SelectedIndex)
            {
                case 1:
                    //Aumentamos el contador
                    this.contarg += 1;
                    //asignamos el cod_trabajador
                    usuario.cod_trabajador = contarg.ToString();
                    //El metodo lo transforma al sig formato: TRAB-$Nacionalidad-$id
                    usuario.CodigoTrab();
                    break;

                case 2:
                    //Aumentamos contador brasil
                    this.contbra += 1;
                    //Asignamos el codigo numerico
                    usuario.cod_trabajador = contbra.ToString();
                    //Transformamos a formato solicitado
                    usuario.CodigoTrab();
                    break;

                case 3:
                    //Lo mismo que el caso anterior solo que ahora es chile
                    this.contchi += 1;
                    usuario.cod_trabajador = contchi.ToString();
                    usuario.CodigoTrab();
                    break;

                case 4:
                    //Lo mismo que el caso anterior solo que ahora es Uruguay
                    this.conturu += 1;
                    usuario.cod_trabajador = conturu.ToString();
                    usuario.CodigoTrab();
                    break;

                case 5:
                    //Lo mismo que el caso 
                    this.contpara += 1;
                    usuario.cod_trabajador = contpara.ToString();
                    usuario.CodigoTrab();
                    break;

                case 6:
                    this.contperu += 1;
                    usuario.cod_trabajador = contperu.ToString();
                    usuario.CodigoTrab();
                    break;
            }

            //Si el formulario se lleno correctamente se ejecuta:
            if(errores.Length == 0)
            {
                //Añadir usuario a lista
                lista.Add(usuario);
                //DataGrid utilizara la lista como medio de datos
                dgResultados.ItemsSource = lista;
                //Se refresca el DataGrid
                dgResultados.Items.Refresh();
                //Se crea el usuario
                usuario = new Usuario();
                //En caso de ejecutarse el codigo correctamente muestra este mensaje
                MessageBox.Show("Persona agregada con éxito!!");
            }
            else
            {
                //Caso contrario Muestra campos con errores de entrada
                MessageBox.Show("Se presentaron los siguientes errores:\n" + errores);
            }

            
        }

    }
}
