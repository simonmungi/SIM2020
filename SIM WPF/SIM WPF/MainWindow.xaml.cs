using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;

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
                    lstTablaFrecuencias.ItemsSource = null;
                    lstTablaFrecuenciasTotales.ItemsSource = null;
                    long x1;
                    long semillaActual = long.Parse(txtSemilla.Text);
                    List<lista> lista = new List<lista>();
                    decimal resultado = semillaActual / decimal.Parse(txtModulo.Text);
                    decimal decimal4 = decimal.Round(resultado, 4);
                    lista.Add(new lista(1, semillaActual, decimal4));
                    for (int i = 1; i < long.Parse(txtCantNumeros.Text); i++)
                    {
                        x1 = (long.Parse(txtCteMult.Text) * semillaActual + long.Parse(txtCteAdit.Text)) % long.Parse(txtModulo.Text);
                        resultado = x1 / decimal.Parse(txtModulo.Text);
                        decimal4 = decimal.Round(resultado, 4);
                        lista.Add(new lista(i + 1, x1, decimal4));
                        semillaActual = x1;
                    }
                    lstNumerosRandom.ItemsSource = lista;
                }
                if (seleccion == "Método Multiplicativo")
                {
                    lstTablaFrecuencias.ItemsSource = null;
                    lstTablaFrecuenciasTotales.ItemsSource = null;
                    long x1;
                    long semillaActual = long.Parse(txtSemilla.Text);
                    List<lista> lista = new List<lista>();
                    decimal resultado = semillaActual / decimal.Parse(txtModulo.Text);
                    decimal decimal4 = decimal.Round(resultado, 4);
                    lista.Add(new lista(1, semillaActual, decimal4));
                    for (int i = 1; i < long.Parse(txtCantNumeros.Text); i++)
                    {
                        x1 = (long.Parse(txtCteMult.Text) * semillaActual) % long.Parse(txtModulo.Text);
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
                if (long.Parse(txtCantNumeros.Text) % long.Parse(txtIntervalos.Text) != 0)
                {
                    System.Windows.MessageBox.Show("La cantidad de numeros a generar debe ser divisible por la cantidad de intervalos." +
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
                        long limiteInferior = long.Parse(txtLimiteInferior.Text);
                        long limiteSuperior = long.Parse(txtLimiteSuperior.Text);
                        decimal maximo = 0;
                        decimal minimo = 1;
                        for (int i = 0; i < long.Parse(txtCantNumeros.Text); i++)
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

                        long intervalos = long.Parse(txtIntervalos.Text);
                        decimal paso = (maximo - minimo) / intervalos;

                        // Generar vector con Frecuencias Esperadas

                        long[] frecuenciasEsperadas = calcularFrecuenciasEsperadas(intervalos, maximo, minimo);

                        //Calcula las frecuencias observadas

                        long[] frecuenciasObservadas = calcularFrecuenciasObservadas(intervalos, lista, minimo, paso);

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
                        long x1;
                        long semillaActual = long.Parse(txtSemilla.Text);
                        List<listaRandom> lista = new List<listaRandom>();
                        decimal limiteInferior = decimal.Parse(txtLimiteInferior.Text);
                        decimal limiteSuperior = decimal.Parse(txtLimiteSuperior.Text);
                        decimal maximo = 0;
                        decimal minimo = 1;
                        decimal resultado = semillaActual / decimal.Parse(txtModulo.Text);
                        decimal decimal4 = decimal.Round(resultado, 4);
                        decimal variable = limiteInferior + decimal4 * (limiteSuperior - limiteInferior);
                        lista.Add(new listaRandom(1, decimal4, variable));
                        for (int i = 1; i < long.Parse(txtCantNumeros.Text); i++)
                        {
                            x1 = (long.Parse(txtCteMult.Text) * semillaActual + long.Parse(txtCteAdit.Text)) % long.Parse(txtModulo.Text);
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
                        long intervalos = long.Parse(txtIntervalos.Text);
                        decimal paso = (maximo - minimo) / intervalos;
                        // Generar vector con Frecuencias Esperadas

                        long[] frecuenciasEsperadas = calcularFrecuenciasEsperadas(intervalos, maximo, minimo);

                        //Calcula las frecuencias observadas

                        long[] frecuenciasObservadas = calcularFrecuenciasObservadas(intervalos, lista, minimo, paso);

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
                        long x1;
                        long semillaActual = long.Parse(txtSemilla.Text);
                        List<listaRandom> lista = new List<listaRandom>();
                        long limiteInferior = long.Parse(txtLimiteInferior.Text);
                        long limiteSuperior = long.Parse(txtLimiteSuperior.Text);
                        decimal maximo = 0;
                        decimal minimo = 1;
                        decimal resultado = semillaActual / decimal.Parse(txtModulo.Text);
                        decimal decimal4 = decimal.Round(resultado, 4);
                        decimal variable = limiteInferior + decimal4 * (limiteSuperior - limiteInferior);
                        lista.Add(new listaRandom(1, decimal4, variable));
                        for (int i = 1; i < long.Parse(txtCantNumeros.Text); i++)
                        {
                            x1 = (long.Parse(txtCteMult.Text) * semillaActual) % long.Parse(txtModulo.Text);
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

                        long intervalos = long.Parse(txtIntervalos.Text);
                        decimal paso = (maximo - minimo) / intervalos;

                        // Generar vector con Frecuencias Esperadas

                        long[] frecuenciasEsperadas = calcularFrecuenciasEsperadas(intervalos, maximo, minimo);

                        //Calcula las frecuencias observadas
                        long[] frecuenciasObservadas = calcularFrecuenciasObservadas(intervalos, lista, minimo, paso);

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
            public long id { get; set; }
            public long Xi { get; set; }
            public decimal random { get; set; }
            public lista(long id, long Xi, decimal random)
            {
                this.id = id;
                this.Xi = Xi;
                this.random = random;
            }
            public lista(long id, decimal random)
            {
                this.id = id;
                this.random = random;
            }
        }
        public class listaRandom
        {
            public long id { get; set; }
            public decimal random { get; set; }

            public decimal variable { get; set; }
            public listaRandom(long id, decimal random, decimal variable)
            {
                this.id = id;
                this.random = random;
                this.variable = variable;
            }

        }
        public class listaChiCuadrado
        {
            public long id { get; set; }
            public decimal minvalue { get; set; }

            public decimal maxvalue { get; set; }
            public long frecuenciaEsperada { get; set; }
            public long frecuenciaObservada { get; set; }

            public decimal valorMedio { get; set; }

            public listaChiCuadrado(long id, decimal minvalue, decimal maxvalue, long frecuenciaEsperada, long frecuenciaObservada, decimal valorMedio)
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
            public long TotalFrecuenciasEsperadas { get; set; }
            public long TotalFrecuenciasObservadas { get; set; }
            public decimal SumaValoresMedios { get; set; }
            public listaTotales(long FrecuenciasEsperadas, long FrecuenciasObservadas, decimal valoresMedios)
            {
                this.TotalFrecuenciasEsperadas = FrecuenciasEsperadas;
                this.TotalFrecuenciasObservadas = FrecuenciasObservadas;
                this.SumaValoresMedios = valoresMedios;
            }

        }
        public (long, long[], long[], decimal[], decimal[]) validarIntervalos(long intervalos, long[] frecuenciasObservadas, long[] frecuenciasEsperadas, decimal[] valoresMaximos, decimal[] valoresMinimos)
        {
            for (int i = 0; i < intervalos; i++)
            {
                if (frecuenciasObservadas[i] < 5)
                {
                    long[] nuevasFrecuenciasObservadas = new long[intervalos - 1];
                    long[] nuevasFrecuenciasEsperadas = new long[intervalos - 1];
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
        public void mostrarLista(long intervalos, long[] frecuenciasObservadas, long[] frecuenciasEsperadas, decimal[] valoresMaximos, decimal[] valoresMinimos)
        {
            List<listaChiCuadrado> tablaChiCuadrado = new List<listaChiCuadrado>();
            long totalFrecuenciasObservadas = 0;
            long totalFrecuenciasEsperadas = 0;
            decimal totalValoresMedios = 0;
            for (int i = 0; i < intervalos; i++)
            {
                long resta = (frecuenciasObservadas[i] - frecuenciasEsperadas[i]);
                long cuadrado = resta * resta;
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
        public long[] calcularFrecuenciasObservadas(long intervalos, List<listaRandom> lista, decimal minimo, decimal paso)
        {
            long[] frecuenciasObservadas = new long[intervalos];
            for (int i = 0; i < long.Parse(txtCantNumeros.Text); i++)
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
        public (decimal[], decimal[]) calcularLimitesIntervalos(long intervalos, decimal minimo, decimal paso)
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
        public long[] calcularFrecuenciasEsperadas(long intervalos, decimal maximo, decimal minimo)
        {

            long[] frecuenciasEsperadas = new long[intervalos];
            for (int i = 0; i < intervalos; i++)
            {
                frecuenciasEsperadas[i] = long.Parse(txtCantNumeros.Text) / intervalos;
            }
            return frecuenciasEsperadas;
        }

        private void btnExportarDatos_Click(object sender, RoutedEventArgs e)
        {
            if (lstTablaFrecuencias.Items.Count == 0)
            {
                MessageBox.Show("Primero debe generar la tabla de frecuencias");
            }
            else
            {
                using (var w = new StreamWriter("Tabla de Frecuencias.csv"))
                {
                    var line = string.Format("{0},{1},{2},{3},{4}, {5}, {6}", "Nro Intervalo", "Minimo Intervalo", "Maximo Intervalo", "Promedio Intervalo", "Frecuencia Esperada", "Frecuencia Observada", "Valor Medio");
                    w.WriteLine(line);
                    w.Flush();
                    foreach (listaChiCuadrado item in lstTablaFrecuencias.Items)
                    {
                        var id = item.id;
                        var maxvalue = item.maxvalue;
                        var minvalue = item.minvalue;
                        var promvalue = (maxvalue - minvalue) / 2 + minvalue;
                        var frecuenciaEsperada = item.frecuenciaEsperada;
                        var frecuenciaObservada = item.frecuenciaObservada;
                        var valorMedio = item.valorMedio;
                        line = string.Format("{0},{1},{2},{3},{4}, {5}, {6}", id, minvalue, maxvalue, promvalue, frecuenciaEsperada, frecuenciaObservada, valorMedio);
                        w.WriteLine(line);
                        w.Flush();
                    }
                }
            }

        }        
    }
}
