using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculadora
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void bResultado_Click(object sender, EventArgs e)
        {
            int valor1 = int.Parse(tValor1.Text), valor2 = int.Parse(tValor2.Text), resultado =0, suma =0, resta =0, division = 0, multiplicacion = 1;
            string resultadoCombinado = "", resultadoSimple = "";
            switch(rbtnOperador.SelectedItem.Value)
            {
                case "suma":
                    resultado = valor1 + valor2;
                    resultadoSimple = "";
                    resultadoSimple += rbtnOperador.SelectedItem.Text + ": ";
                    break;
                case "resta":
                    resultado = valor1 - valor2;
                    resultadoSimple = "";
                    resultadoSimple += rbtnOperador.SelectedItem.Text + ": ";
                    break;
                case "multiplicacion":
                    resultado = valor1 * valor2;
                    resultadoSimple = "";
                    resultadoSimple += rbtnOperador.SelectedItem.Text + ": ";
                    break;
                case "division":
                    resultado = (valor1 != 0 ? valor1 / valor2 : 0);
                    resultadoSimple = "";
                    resultadoSimple += rbtnOperador.SelectedItem.Text + ": ";
                    break;
                default:
                    resultado = 0;
                    break;
            }

            foreach(ListItem op in cbxOperador.Items)
            {
                if (op.Selected)
                {
                    switch (op.Value)
                    {
                        case "suma":
                            resultadoCombinado += " Suma: " +(valor1 + valor2) + " ";
                            break;
                        case "resta":
                            resultadoCombinado += " Resta: " + (valor1 - valor2) + " ";
                            break;
                        case "multiplicacion":
                            resultadoCombinado += " Multiplicacion: " + (valor1 * valor2) + " ";
                            break;
                        case "division":
                            resultadoCombinado += " Division: " + ((valor1 != 0 ? valor1 / valor2 : 0) != 0 ? (valor1 != 0 ? valor1 / valor2 : 0).ToString() : "Division por Cero no permitida") + " ";
                            break;
                        default:
                            resultadoCombinado = "Sin resultados";
                            break;
                    }
                }
            }
            lResultado.Text = resultadoSimple + resultado.ToString();
            lResultadoCombinado.Text = resultadoCombinado;
        }

        protected void bLimpiar_Click(object sender, EventArgs e)
        {
            lResultado.Text = "Resultado";
            lResultadoCombinado.Text = "Resultado combinado";
        }
    }
}