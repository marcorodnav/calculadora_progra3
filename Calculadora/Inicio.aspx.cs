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
            int valor1 = int.Parse(tValor1.Text), valor2 = int.Parse(tValor2.Text), resultado =0;
            switch(rbtnOperador.SelectedItem.Value)
            {
                case "suma":
                    resultado = valor1 + valor2;
                    break;
                case "resta":
                    resultado = valor1 - valor2;
                    break;
                case "multiplicacion":
                    resultado = valor1 * valor2;
                    break;
                case "division":
                    resultado = (valor1 != 0 ? valor1 / valor2 : 0);
                    break;
                default:
                    resultado = 0;
                    break;
            }
            lResultado.Text = resultado.ToString();
        }
    }
}