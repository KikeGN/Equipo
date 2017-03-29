using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLOTHWARE
{
    public partial class CONEXION : Form
    {
        public CONEXION()
        {
            InitializeComponent();
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            clsConexion con = new clsConexion();
            con.comprobarConexion();
        }
    }
}
