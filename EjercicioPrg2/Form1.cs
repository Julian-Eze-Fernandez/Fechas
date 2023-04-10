using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioPrg2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Creamos las variables.
        public decimal dia;
        public string mes;
        public decimal año;
        public string Resultado;

        //Constantes que luego saldran en los errores.
        const string ERROR_DATOS = "Faltan datos de cargar.";
        const string ERROR_DIAS = "Ingrese un dia valido.";
        const string ERROR_NUMERICO = "Esta intentando ingresar una letra, ingrese un numero.";
        const string ERROR_FEBRERO = "Febrero trae 28 dias.";


        private void Btn1_Click(object sender, EventArgs e)
        {

            if (!Error())
            {
                //Asignamos el valor a las variables.
                dia = Convert.ToDecimal(TxtDia.Text);
                mes = CmbBoxMes.Text;
                año = Convert.ToDecimal(TxtAño.Text);

                if (!ValidarDias())
                {

                    //Al dia que insertamos le sumamos 1+.
                    if (0 < dia && dia < 30)
                    {
                        dia++;
                    }
                    
                    if (mes == "2" && dia == 29)
                    {
                        dia = 28;
                    }


                    //Asignamos el valor en modo string a cada mes y dependiendo el dia que ingreso el usuario cambiara de mes o no.
                    switch (mes)
                    {
                        case "1":
                            mes = "Enero";
                            if (dia == 31)
                            {
                                dia = 1;
                                mes = "Febrero";
                            }
                            break;
                        case "2":
                            mes = "Febrero";
                            if (dia == 28)
                            {
                                dia = 1;
                                mes = "Marzo";
                            }
                            break;
                        case "3":
                            mes = "Marzo";
                            if (dia == 31)
                            {
                                dia = 1;
                                mes = "Abril";
                            }
                            break;
                        case "4":
                            mes = "Abril";
                            if (dia == 30)
                            {
                                dia = 1;
                                mes = "Mayo";
                            }
                            break;
                        case "5":
                            mes = "Mayo";
                            if (dia == 31)
                            {
                                dia = 1;
                                mes = "Junio";
                            }
                            break;
                        case "6":
                            mes = "Junio";
                            if (dia == 30)
                            {
                                dia = 1;
                                mes = "Julio";
                            }
                            break;
                        case "7":
                            mes = "Julio";
                            if (dia == 31)
                            {
                                dia = 1;
                                mes = "Agosto";
                            }
                            break;
                        case "8":
                            mes = "Agosto";
                            if (dia == 31)
                            {
                                dia = 1;
                                mes = "Septiembre";
                            }
                            break;
                        case "9":
                            mes = "Septiembre";
                            if (dia == 30)
                            {
                                dia = 1;
                                mes = "Octubre";
                            }
                            break;
                        case "10":
                            mes = "Octubre";
                            if (dia == 31)
                            {
                                dia = 1;
                                mes = "Noviembre";
                            }
                            break;
                        case "11":
                            mes = "Noviembre";
                            if (dia == 30)
                            {
                                dia = 1;
                                mes = "Diciembre";
                            }
                            break;
                        case "12":
                            mes = "Diciembre";
                            if (dia == 31)
                            {
                                dia = 1;
                                mes = "Enero";
                                año++;
                            }
                            break;
                        default:
                            if (mes == "")
                            {
                                mes = "";
                                break;
                            }
                            break;
                    }
                    LimpiarPantalla();

                    //Damos el valor al label
                    LblResultado.Text = dia.ToString() + " de " + mes + " de " + año.ToString();
                }
               
            }

        }

        //Metodo para validar errores.
        private bool Error()
        {
            bool bandera = false;

            //Error por si el usuario ingresa letras.
            for (int i = 0; i < TxtDia.Text.Length; i++)
            {
                char c = TxtDia.Text[i];

                if (!char.IsDigit(c))
                {
                    bandera = true;
                    MessageBox.Show(this, ERROR_NUMERICO, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            //Error por si no se llena los casilleros.
            if (!TxtDia.Text.Any() || !TxtAño.Text.Any() || !CmbBoxMes.Text.Any())
            {
                bandera = true;
                MessageBox.Show(this, ERROR_DATOS, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return bandera;
        }

        //Metodo para validar dias.
        public bool ValidarDias()
        {
            bool bandera = false;

            if (1 > dia || dia > 31)
            {
                bandera = true;
                MessageBox.Show(this, ERROR_DIAS, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (mes == "2" & 28 < dia)
            {
                bandera = true;
                MessageBox.Show(this, ERROR_FEBRERO, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return bandera;
        }

        //Metodo para limpiar pantalla.
        public void LimpiarPantalla()
        {
            TxtDia.Text = "";
            TxtAño.Text = "";
            CmbBoxMes.Text = "";
            LblResultado.Text = "";
        }
    }

}


