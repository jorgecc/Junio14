using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Junio14
{
    public partial class WebUsing : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MiClase obj=new MiClase();
            try
            {
                // aqui hacemos algo
                obj.Dispose(); // esta funcion libera la memoria
            } catch(Exception ex)
            {

            }
            // segunda version
            try
            {
                using(MiClase obj2=new MiClase())
                {
                    // aqui hacemos algo
                }
            } catch(Exception ex)
            {

            } // catch
        } // aqui termina la funcion page_load
    }
}