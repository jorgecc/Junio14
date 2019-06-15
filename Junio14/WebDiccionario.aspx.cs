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
            Stack<string> pila=new Stack<string>();
            Queue<string> cola=new Queue<string>();

            // Stack
            // Queue
            paisesLista.Add("Chile");
            paisesLista.Add("Argentina");

            diccionario.Add("CL","Chile");
            diccionario.Add("AR","Argentina");

            diccionario2.Add(0, "Chile");
            diccionario2.Add(1, "Argentina");


            pila.Push("Chile");
            pila.Push("Argentina");

            cola.Enqueue("Chile");
            cola.Enqueue("Argentina");

            Debug.WriteLine("El primer elemento es lista " + paisesLista[0]);
            Debug.WriteLine("El primer elemento es diccionario  " + diccionario["CL"]);
            Debug.WriteLine("El primer elemento es diccionario2 " + diccionario2[0]);

            Debug.WriteLine("El primer elemento de la pila " + pila.Pop()); // Argentina
            Debug.WriteLine("El primer elemento de la pila " + pila.Pop()); // Chile

            Debug.WriteLine("El primer elemento de la cola " + cola.Dequeue()); // Chile
            Debug.WriteLine("El primer elemento de la cola " + cola.Dequeue()); // Argentina

            //Session["misesion"]="hola mundo";
            //Session.Add("misession","hola mundo");

            TextBox1.Text = Request.QueryString["id"]; // valores enviados por GET (url)
            Debug.WriteLine(FreeTextBox1.Text);
            TextBox2.Text= FreeTextBox1.Text;

            // Request = valores que el usuario envia
            // Respose = Valores que el servidor envia hacia el usuario
            // Session = valores guardados para el usuario.




        } // funcion page_load
    }
}