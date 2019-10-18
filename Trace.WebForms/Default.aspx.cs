using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tracing
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Trace.Write("A pagina default foi carregada");

            try
            {
                var y = 50;
                var i = 0;

                var output = (y / i);
            }
            catch (Exception error)
            {
                Trace.Warn("Ocorreu um erro na pagina Default " + error.Message);
            }
        }
    }
}