using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace newlab
{
    public partial class Lab : System.Web.UI.MasterPage
    {
        protected static string mensaje;
        private static string general_email;
        private static int general_id;

        public static string General_email { get { return general_email; } set { general_email = value; } }
        public static int General_id { get { return general_id; } set { general_id = value; } }
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
    }
}