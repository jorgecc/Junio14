using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Junio14
{
    public partial class WebError : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            int n1=0;
            int n2=0;
            string conectarbasededatos;
            try {
                conectarbasededatos = "conectar"; //conecto
                int n3=n1/n2;
                Debug.WriteLine("Esto no se va a ejecutar");
                conectarbasededatos="cerrar"; // cierro

            } catch(Exception ex)
            {
                Debug.WriteLine("Una excepcion");
                conectarbasededatos = "cerrar";
            }
            /*
            try {  
                int n3=n1/n2;
            } catch(DivideByZeroException ex)
            {
                Debug.WriteLine("div por cero");
            } catch(Exception ex)
            {
                Debug.WriteLine("Una excepcion");
            }
            */

        } // fin de page_load
    }
}