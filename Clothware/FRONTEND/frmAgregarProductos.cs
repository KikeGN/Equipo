using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using Clothware.BACKEND;
using Clothware.FRONTEND;


namespace Clothware.FRONTEND
{
    public partial class frmAgregarProductos : Form
    {
        conexion c = new conexion();
        int stat = 0;
        public frmAgregarProductos()
        {
            InitializeComponent();
        }

        private void frmAgregarProductos_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbStatus.Text == "Alta")
            {
                stat = 1;
            }else if(cbStatus.Text=="Baja")
            {
                stat = 0;
            }

            pojoProducto producto = new pojoProducto(Convert.ToInt32(txtID.Text), cbModelo.Text, cbTalla.Text, txtColor.Text,
                Convert.ToInt32( txtExistencia.Text), cbTela.Text, txtDescripción.Text, double.Parse(txtPrecio.Text),stat);
           

            if (this.Text != "Editar Producto")
            {
                
                c.agregarProducto(producto);

            }
            else
            {
                c.editarProducto(producto);

            }
            this.Dispose();
            Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
