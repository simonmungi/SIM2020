/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace TP_SIM_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (cmbOpciones.SelectedValue == null)
            {
                MessageBox.Show("No se eligió un metodo");
                return;
            }
            
            string opc = cmbOpciones.SelectedValue.ToString();

            if (validar(opc))
            {
                Estrategia est = elegir(opc);
                int cantidad = Convert.ToInt32(txtCantidad.Text);

                Generador generador = new Generador(cantidad, est);

                this.DataGridNumeros.ItemsSource = generador.numeros;

            }
            else return; 

        }

        void DataGrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex()+1).ToString();
        }


        //////////////////////////validaciones//////////////////////////// despues se pueden mover a otro lado
        //TODO: cambiar validaciones para que acepten decimales y negativos segun txt
        
        public bool checkSemilla()
        {
            if (String.IsNullOrEmpty(this.txtSemilla.Text)) {
                
                MessageBox.Show("No se ingresó una semilla");    
                return false; 
            }
            else return true;
        }

        public bool checkCantidad()
        {
            if (String.IsNullOrEmpty(this.txtCantidad.Text))
            {

                MessageBox.Show("No se ingresó una cantidad");
                return false;
            }
            else return true;
        }

        public bool checkA()
        {
            if (String.IsNullOrEmpty(this.txtA.Text))
            {

                MessageBox.Show("No se ingresó valor para A");
                return false;
            }
            else return true;
        }

        public bool checkM()
        {
            if (String.IsNullOrEmpty(this.txtM.Text))
            {

                MessageBox.Show("No se ingresó valor para M");
                return false;
            }
            else return true;
        }

        public bool checkC()
        {
            if (String.IsNullOrEmpty(this.txtC.Text))
            {

                MessageBox.Show("No se ingresó valor para C");
                return false;
            }
            else return true;
        }

        public bool validar(string opc)
        {

            switch (opc)
            {
                case "Mixto":
                    return (checkCantidad() && checkA() && checkC() && checkM() && checkSemilla() );

                case "Multiplicativo":
                    return (checkCantidad() && checkA() && checkM() && checkSemilla());

                case "Random":
                    return (checkCantidad());

                default:
                    return false;

            }

        }

        public Estrategia elegir(string opc)
        {
            Estrategia est;

            switch (opc)//estrategia
            {
                case "Mixto":


                    est = new EstrategiaCongruencialMixto
                    {
                        x0 = Convert.ToInt32(this.txtSemilla.Text),
                        a = Convert.ToInt32(this.txtA.Text),
                        c = Convert.ToInt32(this.txtC.Text),
                        m = Convert.ToInt32(this.txtM.Text)
                    };

                    return est;

                case "Multiplicativo":
                    est = new EstrategiaCongruencialMultiplicativo
                    {
                        x0 = Convert.ToInt32(this.txtSemilla.Text),
                        a = 17,
                        m = 5000
                    };
                    return est;

                case "Random":
                    est = new EstrategiaRandom();
                    return est;

                default:
                    return null;

            }

        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
*/