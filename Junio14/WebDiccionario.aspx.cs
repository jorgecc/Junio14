using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Junio14
{
    public partial class WebDiccionario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] paises=new string[3] {"Chile","Argentina","Peru"};
            List<string> paisesLista=new List<string>();
            Dictionary<string,string> diccionario=new Dictionary<string, string>();
            Dictionary<int, string> diccionario2 = new Dictionary<int, string>();
            // Stack
            // Queue
            paisesLista.Add("Chile");
            paisesLista.Add("Argentina");

            diccionario.Add("CL","Chile");
            diccionario.Add("AR","Argentina");

            diccionario2.Add(0, "Chile");
            diccionario2.Add(1, "Argentina");

            Debug.WriteLine("El primer elemento es " + paisesLista[0]);
            Debug.WriteLine("El primer elemento es " + diccionario["CL"]);
            Debug.WriteLine("El primer elemento es " + diccionario2[0]);




        }
    }
}