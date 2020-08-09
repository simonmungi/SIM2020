using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace SIM_WPF
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

        private void btnACalcularNumeros_Click(object sender, RoutedEventArgs e)
        {
            var selected = cmbMetodoElegido.SelectedItem as ComboBoxItem;
            if (selected != null)
            {
                String seleccion = selected.Content.ToString();
                if (seleccion == "Método Mixto")
                {
                    int x1;
                    int semillaActual = int.Parse(txtSemilla.Text);
                    List<lista> lista = new List<lista>();
                    decimal resultado = semillaActual / decimal.Parse(txtModulo.Text);
                    decimal decimal4 = decimal.Round(resultado, 4);
                    lista.Add(new lista(1, semillaActual, decimal4));
                    for (int i = 1; i < int.Parse(txtCantNumeros.Text); i++)
                    {
                        x1 = (int.Parse(txtCteMult.Text) * semillaActual + int.Parse(txtCteAdit.Text)) % int.Parse(txtModulo.Text);
                        resultado = x1 / decimal.Parse(txtModulo.Text);
                        decimal4 = decimal.Round(resultado, 4);
                        lista.Add(new lista(i + 1, x1, decimal4));
                        semillaActual = x1;
                    }
                    lstNumerosRandom.ItemsSource = lista;
                }
                if (seleccion == "Método Multiplicativo")
                {
                    int x1;
                    int semillaActual = int.Parse(txtSemilla.Text);
                    List<lista> lista = new List<lista>();
                    decimal resultado = semillaActual / decimal.Parse(txtModulo.Text);
                    decimal decimal4 = decimal.Round(resultado, 4);
                    lista.Add(new lista(1, semillaActual, decimal4));
                    for (int i = 1; i < int.Parse(txtCantNumeros.Text); i++)
                    {
                        x1 = (int.Parse(txtCteMult.Text) * semillaActual) % int.Parse(txtModulo.Text);
                        resultado = x1 / decimal.Parse(txtModulo.Text);
                        decimal4 = decimal.Round(resultado, 4);
                        lista.Add(new lista(i + 1, x1, decimal4));
                        semillaActual = x1;
                    }
                    lstNumerosRandom.ItemsSource = lista;
                }
                if (seleccion == "Generado por el lenguaje de programación")
                {
                    MessageBox.Show("Esta opción no está disponible para la generación a través de lenguaje de programación");

                }

            }

            else
            {
                MessageBox.Show("Debe seleccionar un método de cálculo de los números random");
            }
        }
        private void btnBCalcularNumeros_Click(object sender, RoutedEventArgs e)
        {
            var selected = cmbMetodoElegido.SelectedItem as ComboBoxItem;
            if (selected != null)
            {
                if (int.Parse(txtCantNumeros.Text) % int.Parse(txtIntervalos.Text) != 0)
                {
                    MessageBox.Show("La cantidad de numeros a generar debe ser divisible por la cantidad de intervalos." +
                        " Por favor revise los valores ingresados.");
                }
                else
                {
                    String seleccion = selected.Content.ToString();
                    if (seleccion == "Generado por el lenguaje de programación")
                    {
                        //Calcula los valores de las variables aleatorias

                        List<listaRandom> lista = new List<listaRandom>();
                        Random random = new Random();
                        int limiteInferior = int.Parse(txtLimiteInferior.Text);
                        int limiteSuperior = int.Parse(txtLimiteSuperior.Text);
                        decimal maximo = 0;
                        decimal minimo = 1;
                        for (int i = 0; i < int.Parse(txtCantNumeros.Text); i++)
                        {
                            decimal proximo = ((decimal)(random.Next(1, 10000)) / 10000);
                            decimal variable = limiteInferior + proximo * (limiteSuperior - limiteInferior);
                            lista.Add(new listaRandom(i + 1, proximo, variable));
                            if (variable > maximo)
                            {
                                maximo = variable;
                            }
                            if (variable < minimo)
                            {
                                minimo = variable;
                            }
                        }
                        lstNumerosRandom.ItemsSource = lista;

                        int intervalos = int.Parse(txtIntervalos.Text);
                        decimal paso = (maximo - minimo) / intervalos;

                        // Generar vector con Frecuencias Esperadas

                        int[] frecuenciasEsperadas = calcularFrecuenciasEsperadas(intervalos, maximo, minimo);

                        //Calcula las frecuencias observadas

                        int[] frecuenciasObservadas = calcularFrecuenciasObservadas(intervalos, lista, minimo, paso);

                        // Calcula los limites de los intervalos

                        (decimal[] valoresMinimos, decimal[] valoresMaximos) = calcularLimitesIntervalos(intervalos, minimo, paso);

                        //Valida que todos los intervalos tengan mas de 5 valores, si no es asi agrupar

                        (intervalos, frecuenciasObservadas, frecuenciasEsperadas, valoresMaximos, valoresMinimos) =
                            validarIntervalos(intervalos, frecuenciasObservadas, frecuenciasEsperadas, valoresMaximos, valoresMinimos);

                        //Generar lista a mostrar
                        mostrarLista(intervalos, frecuenciasObservadas, frecuenciasEsperadas, valoresMaximos, valoresMinimos);
                    }
                    if (seleccion == "Método Mixto")
                    {
                        int x1;
                        int semillaActual = int.Parse(txtSemilla.Text);
                        List<listaRandom> lista = new List<listaRandom>();
                        int limiteInferior = int.Parse(txtLimiteInferior.Text);
                        int limiteSuperior = int.Parse(txtLimiteSuperior.Text);
                        decimal maximo = 0;
                        decimal minimo = 1;
                        decimal resultado = semillaActual / decimal.Parse(txtModulo.Text);
                        decimal decimal4 = decimal.Round(resultado, 4);
                        decimal variable = limiteInferior + decimal4 * (limiteSuperior - limiteInferior);
                        lista.Add(new listaRandom(1, decimal4, variable));
                        for (int i = 1; i < int.Parse(txtCantNumeros.Text); i++)
                        {
                            x1 = (int.Parse(txtCteMult.Text) * semillaActual + int.Parse(txtCteAdit.Text)) % int.Parse(txtModulo.Text);
                            resultado = x1 / decimal.Parse(txtModulo.Text);
                            decimal4 = decimal.Round(resultado, 4);
                            variable = limiteInferior + decimal4 * (limiteSuperior - limiteInferior);
                            lista.Add(new listaRandom(i + 1, decimal4, variable));
                            if (variable > maximo)
                            {
                                maximo = variable;
                            }
                            if (variable < minimo)
                            {
                                minimo = variable;
                            }
                            semillaActual = x1;
                        }
                        lstNumerosRandom.ItemsSource = lista;
                        int intervalos = int.Parse(txtIntervalos.Text);
                        decimal paso = (maximo - minimo) / intervalos;
                        // Generar vector con Frecuencias Esperadas

                        int[] frecuenciasEsperadas = calcularFrecuenciasEsperadas(intervalos, maximo, minimo);

                        //Calcula las frecuencias observadas

                        int[] frecuenciasObservadas = calcularFrecuenciasObservadas(intervalos, lista, minimo, paso);

                        // Calcula los limites de los intervalos

                        (decimal[] valoresMinimos, decimal[] valoresMaximos) = calcularLimitesIntervalos(intervalos, minimo, paso);

                        //Valida que todos los intervalos tengan mas de 5 valores, si no es asi agrupar

                        (intervalos, frecuenciasObservadas, frecuenciasEsperadas, valoresMaximos, valoresMinimos) =
                            validarIntervalos(intervalos, frecuenciasObservadas, frecuenciasEsperadas, valoresMaximos, valoresMinimos);

                        //Generar lista a mostrar
                        mostrarLista(intervalos, frecuenciasObservadas, frecuenciasEsperadas, valoresMaximos, valoresMinimos);
                    }
                    if (seleccion == "Método Multiplicativo")
                    {
                        int x1;
                        int semillaActual = int.Parse(txtSemilla.Text);
                        List<listaRandom> lista = new List<listaRandom>();
                        int limiteInferior = int.Parse(txtLimiteInferior.Text);
                        int limiteSuperior = int.Parse(txtLimiteSuperior.Text);
                        decimal maximo = 0;
                        decimal minimo = 1;
                        decimal resultado = semillaActual / decimal.Parse(txtModulo.Text);
                        decimal decimal4 = decimal.Round(resultado, 4);
                        decimal variable = limiteInferior + decimal4 * (limiteSuperior - limiteInferior);
                        lista.Add(new listaRandom(1, decimal4, variable));
                        for (int i = 1; i < int.Parse(txtCantNumeros.Text); i++)
                        {
                            x1 = (int.Parse(txtCteMult.Text) * semillaActual) % int.Parse(txtModulo.Text);
                            resultado = x1 / decimal.Parse(txtModulo.Text);
                            decimal4 = decimal.Round(resultado, 4);
                            variable = limiteInferior + decimal4 * (limiteSuperior - limiteInferior);
                            lista.Add(new listaRandom(i + 1, decimal4, variable));
                            if (variable > maximo)
                            {
                                maximo = variable;
                            }
                            if (variable < minimo)
                            {
                                minimo = variable;
                            }
                            semillaActual = x1;
                        }
                        lstNumerosRandom.ItemsSource = lista;

                        int intervalos = int.Parse(txtIntervalos.Text);
                        decimal paso = (maximo - minimo) / intervalos;

                        // Generar vector con Frecuencias Esperadas

                        int[] frecuenciasEsperadas = calcularFrecuenciasEsperadas(intervalos, maximo, minimo);

                        //Calcula las frecuencias observadas
                        int[] frecuenciasObservadas = calcularFrecuenciasObservadas(intervalos, lista, minimo, paso);

                        // Calcula los limites de los intervalos

                        (decimal[] valoresMinimos, decimal[] valoresMaximos) = calcularLimitesIntervalos(intervalos, minimo, paso);

                        //Valida que todos los intervalos tengan mas de 5 valores, si no es asi agrupar
                        (intervalos, frecuenciasObservadas, frecuenciasEsperadas, valoresMaximos, valoresMinimos) =
                            validarIntervalos(intervalos, frecuenciasObservadas, frecuenciasEsperadas, valoresMaximos, valoresMinimos);
                        //Generar lista a mostrar
                        mostrarLista(intervalos, frecuenciasObservadas, frecuenciasEsperadas, valoresMaximos, valoresMinimos);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un método de cálculo de los números random");
            }
        }

        private void lstNumeros_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cmbMetodoElegido_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        public class lista
        {
            public int id { get; set; }
            public int Xi { get; set; }
            public decimal random { get; set; }
            public lista(int id, int Xi, decimal random)
            {
                this.id = id;
                this.Xi = Xi;
                this.random = random;
            }
            public lista(int id, decimal random)
            {
                this.id = id;
                this.random = random;
            }
        }
        public class listaRandom
        {
            public int id { get; set; }
            public decimal random { get; set; }

            public decimal variable { get; set; }
            public listaRandom(int id, decimal random, decimal variable)
            {
                this.id = id;
                this.random = random;
                this.variable = variable;
            }

        }
        public class listaChiCuadrado
        {
            public int id { get; set; }
            public decimal minvalue { get; set; }

            public decimal maxvalue { get; set; }
            public int frecuenciaEsperada { get; set; }
            public int frecuenciaObservada { get; set; }

            public decimal valorMedio { get; set; }

            public listaChiCuadrado(int id, decimal minvalue, decimal maxvalue, int frecuenciaEsperada, int frecuenciaObservada, decimal valorMedio)
            {
                this.id = id;
                this.minvalue = minvalue;
                this.maxvalue = maxvalue;
                this.frecuenciaEsperada = frecuenciaEsperada;
                this.frecuenciaObservada = frecuenciaObservada;
                this.valorMedio = valorMedio;

            }

        }
        public class listaTotales
        {
            public int TotalFrecuenciasEsperadas { get; set; }
            public int TotalFrecuenciasObservadas { get; set; }
            public decimal SumaValoresMedios { get; set; }
            public listaTotales(int FrecuenciasEsperadas, int FrecuenciasObservadas, decimal valoresMedios)
            {
                this.TotalFrecuenciasEsperadas = FrecuenciasEsperadas;
                this.TotalFrecuenciasObservadas = FrecuenciasObservadas;
                this.SumaValoresMedios = valoresMedios;
            }

        }
        public (int, int[], int[], decimal[], decimal[]) validarIntervalos(int intervalos, int[] frecuenciasObservadas, int[] frecuenciasEsperadas, decimal[] valoresMaximos, decimal[] valoresMinimos)
        {
            for (int i = 0; i < intervalos; i++)
            {
                if (frecuenciasObservadas[i] < 5)
                {
                    int[] nuevasFrecuenciasObservadas = new int[intervalos - 1];
                    int[] nuevasFrecuenciasEsperadas = new int[intervalos - 1];
                    decimal[] nuevosValoresMinimos = new decimal[intervalos - 1];
                    decimal[] nuevosValoresMaximos = new decimal[intervalos - 1];
                    if (i == 0)
                    {
                        nuevasFrecuenciasObservadas[0] = frecuenciasObservadas[0] + frecuenciasObservadas[1];
                        nuevasFrecuenciasEsperadas[0] = frecuenciasEsperadas[0] + frecuenciasEsperadas[1];
                        nuevosValoresMaximos[0] = valoresMaximos[1];
                        nuevosValoresMinimos[0] = valoresMinimos[0];
                        for (int j = 1; j < intervalos - 1; j++)
                        {
                            nuevasFrecuenciasObservadas[j] = frecuenciasObservadas[j + 1];
                            nuevasFrecuenciasEsperadas[j] = frecuenciasEsperadas[j + 1];
                            nuevosValoresMinimos[j] = valoresMinimos[j + 1];
                            nuevosValoresMaximos[j] = valoresMaximos[j + 1];
                        }

                    }
                    else
                    {
                        if (i == intervalos - 1)
                        {
                            nuevasFrecuenciasObservadas[i - 1] = frecuenciasObservadas[i - 1] + frecuenciasObservadas[i];
                            nuevasFrecuenciasEsperadas[i - 1] = frecuenciasEsperadas[i - 1] + frecuenciasEsperadas[i];
                            nuevosValoresMaximos[i - 1] = valoresMaximos[i];
                            nuevosValoresMinimos[i - 1] = valoresMinimos[i - 1];
                            for (int j = 0; j < intervalos - 2; j++)
                            {
                                nuevasFrecuenciasObservadas[j] = frecuenciasObservadas[j];
                                nuevasFrecuenciasEsperadas[j] = frecuenciasEsperadas[j];
                                nuevosValoresMinimos[j] = valoresMinimos[j];
                                nuevosValoresMaximos[j] = valoresMaximos[j];
                            }
                        }
                        else
                        {
                            if (frecuenciasEsperadas[i - 1] < frecuenciasEsperadas[i + 1])
                            {

                                for (int j = 0; j < i - 1; j++)
                                {
                                    nuevasFrecuenciasObservadas[j] = frecuenciasObservadas[j];
                                    nuevasFrecuenciasEsperadas[j] = frecuenciasEsperadas[j];
                                    nuevosValoresMinimos[j] = valoresMinimos[j];
                                    nuevosValoresMaximos[j] = valoresMaximos[j];
                                }
                                nuevasFrecuenciasObservadas[i - 1] = frecuenciasObservadas[i - 1] + frecuenciasObservadas[i];
                                nuevasFrecuenciasEsperadas[i - 1] = frecuenciasEsperadas[i - 1] + frecuenciasEsperadas[i];
                                nuevosValoresMaximos[i - 1] = valoresMaximos[i];
                                nuevosValoresMinimos[i - 1] = valoresMinimos[i - 1];
                                for (int j = i; j < intervalos - 1; j++)
                                {
                                    nuevasFrecuenciasObservadas[j] = frecuenciasObservadas[j + 1];
                                    nuevasFrecuenciasEsperadas[j] = frecuenciasEsperadas[j + 1];
                                    nuevosValoresMinimos[j] = valoresMinimos[j + 1];
                                    nuevosValoresMaximos[j] = valoresMaximos[j + 1];
                                }

                            }
                            else
                            {
                                for (int j = 0; j < i; j++)
                                {
                                    nuevasFrecuenciasObservadas[j] = frecuenciasObservadas[j];
                                    nuevasFrecuenciasEsperadas[j] = frecuenciasEsperadas[j];
                                    nuevosValoresMinimos[j] = valoresMinimos[j];
                                    nuevosValoresMaximos[j] = valoresMaximos[j];
                                }
                                nuevasFrecuenciasObservadas[i] = frecuenciasObservadas[i] + frecuenciasObservadas[i + 1];
                                nuevasFrecuenciasEsperadas[i] = frecuenciasEsperadas[i] + frecuenciasEsperadas[i + 1];
                                nuevosValoresMaximos[i] = valoresMaximos[i + 1];
                                nuevosValoresMinimos[i] = valoresMinimos[i];
                                for (int j = i + 1; j < intervalos - 1; j++)
                                {
                                    nuevasFrecuenciasObservadas[j] = frecuenciasObservadas[j + 1];
                                    nuevasFrecuenciasEsperadas[j] = frecuenciasEsperadas[j + 1];
                                    nuevosValoresMinimos[j] = valoresMinimos[j + 1];
                                    nuevosValoresMaximos[j] = valoresMaximos[j + 1];
                                }
                            }
                        }

                    }
                    frecuenciasObservadas = nuevasFrecuenciasObservadas;
                    frecuenciasEsperadas = nuevasFrecuenciasEsperadas;
                    valoresMinimos = nuevosValoresMinimos;
                    valoresMaximos = nuevosValoresMaximos;
                    intervalos = intervalos - 1;
                    i = -1;

                }
            }
            return (intervalos, frecuenciasObservadas, frecuenciasEsperadas, valoresMaximos, valoresMinimos);
        }
        public void mostrarLista(int intervalos, int[] frecuenciasObservadas, int[] frecuenciasEsperadas, decimal[] valoresMaximos, decimal[] valoresMinimos)
        {
            List<listaChiCuadrado> tablaChiCuadrado = new List<listaChiCuadrado>();
            int totalFrecuenciasObservadas = 0;
            int totalFrecuenciasEsperadas = 0;
            decimal totalValoresMedios = 0;
            for (int i = 0; i < intervalos; i++)
            {
                int resta = (frecuenciasObservadas[i] - frecuenciasEsperadas[i]);
                int cuadrado = resta * resta;
                decimal valorMedio = (decimal)cuadrado / frecuenciasObservadas[i];
                valorMedio = decimal.Round(valorMedio, 4);
                totalFrecuenciasObservadas += frecuenciasObservadas[i];
                totalFrecuenciasEsperadas += frecuenciasEsperadas[i];
                totalValoresMedios += valorMedio;
                tablaChiCuadrado.Add(new listaChiCuadrado(i + 1, valoresMinimos[i], valoresMaximos[i], frecuenciasEsperadas[i], frecuenciasObservadas[i], valorMedio));
            }
            lstTablaFrecuencias.ItemsSource = tablaChiCuadrado;
            List<listaTotales> listaTotales = new List<listaTotales>();
            listaTotales.Add(new listaTotales(totalFrecuenciasEsperadas, totalFrecuenciasObservadas, totalValoresMedios));
            lstTablaFrecuenciasTotales.ItemsSource = listaTotales;
            if (totalValoresMedios <= decimal.Parse(txtChiCuadrado.Text))
            {
                txtResultado.Text = "Para los valores ingresados no hay evidencia que la distribución no sea uniforme";
            }
            else
            {
                txtResultado.Text = "Para los valores ingresados podemos asegurar que la distribución no es uniforme";
            }
        }
        public int[] calcularFrecuenciasObservadas(int intervalos, List<listaRandom> lista, decimal minimo, decimal paso)
        {
            int[] frecuenciasObservadas = new int[intervalos];
            for (int i = 0; i < int.Parse(txtCantNumeros.Text); i++)
            {
                for (int j = 0; j < intervalos; j++)
                {
                    if (lista[i].variable <= (minimo + paso * (j + 1)))
                    {
                        frecuenciasObservadas[j] = frecuenciasObservadas[j] + 1;
                        break;
                    }
                }
            }
            return frecuenciasObservadas;
        }
        public (decimal[], decimal[]) calcularLimitesIntervalos(int intervalos, decimal minimo, decimal paso)
        {
            decimal[] valoresMinimos = new decimal[intervalos];
            decimal[] valoresMaximos = new decimal[intervalos];
            for (int i = 0; i < intervalos; i++)
            {
                valoresMinimos[i] = minimo + paso * i;
                valoresMaximos[i] = minimo + paso * (i + 1);
            }
            return (valoresMinimos, valoresMaximos);
        }
        public int[] calcularFrecuenciasEsperadas(int intervalos, decimal maximo, decimal minimo)
        {

            int[] frecuenciasEsperadas = new int[intervalos];
            for (int i = 0; i < intervalos; i++)
            {
                frecuenciasEsperadas[i] = int.Parse(txtCantNumeros.Text) / intervalos;
            }
            return frecuenciasEsperadas;
        }
    }
}
