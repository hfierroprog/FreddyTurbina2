﻿using System.Windows;

namespace FreddyTurbina
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Posiciona la ventana en centro de la pantalla
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnBicicleta_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnOfertas_Click(object sender, RoutedEventArgs e)
        {

        }

        //Al hacer click en el personal se ejecutara este codigo:
        private void btnPersonal_Click(object sender, RoutedEventArgs e)
        {
            //Instanciamos a la ventana de personal
            Personal p = new Personal();
            //Mostramos la ventana de personal
            p.Show();
            //Cerramos la ventana del menú principal
            Close();
        }
    }
}
