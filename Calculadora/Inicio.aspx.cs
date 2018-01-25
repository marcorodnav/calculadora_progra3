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
            int valor1, valor2, resultado;
            valor1 = valor2 = resultado = 0;
            valor1 = int.Parse(tValor1.Text);
            valor2 = int.Parse(tValor2.Text);
            resultado = valor1 + valor2;
            lResultado.Text = resultado.ToString();
        }
    }
}