using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clothware.FRONTEND;
using Clothware.BACKEND;

namespace Clothware
{
    
    public partial class Form1 : Form
    {
        conexion c = new conexion();
        public Form1()
        {
            InitializeComponent();
        }

       public void cargartablas()
        {
            c.cargartodosdatosproductos(dgProductos);
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            frmAgregarProductos a = new frmAgregarProductos();
            a.ShowDialog();
            cargartablas();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargartablas();
        }

        private void dgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            menuContextual.Show(MousePosition);
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarProductos addProduct = new frmAgregarProductos();
            string stat= this.dgProductos.CurrentRow.Cells[8].Value.ToString();
            if (stat=="0")
            {
                addProduct.cbStatus.Text = "Baja";
            }else if (stat == "1")
            {
                addProduct.cbStatus.Text = "Alta";
            }

            addProduct.txtID.Text = this.dgProductos.CurrentRow.Cells[0].Value.ToString();
            addProduct.cbModelo.Text = this.dgProductos.CurrentRow.Cells[1].Value.ToString();
            addProduct.cbTalla.Text = this.dgProductos.CurrentRow.Cells[2].Value.ToString();
            addProduct.txtPrecio.Text = this.dgProductos.CurrentRow.Cells[7].Value.ToString();
            addProduct.txtColor.Text = this.dgProductos.CurrentRow.Cells[3].Value.ToString();
            addProduct.txtExistencia.Text = this.dgProductos.CurrentRow.Cells[4].Value.ToString();
            addProduct.cbTela.Text = this.dgProductos.CurrentRow.Cells[5].Value.ToString();
            addProduct.txtDescripción.Text = this.dgProductos.CurrentRow.Cells[6].Value.ToString();
            

            addProduct.Text = "Editar Producto";

            addProduct.ShowDialog();
            cargartablas();
        }

        private void dgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string bus = txtBuscar.Text;
            c.buscarProducto(dgProductos, bus);

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cargartablas();
            txtBuscar.Text = "";
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string bus = txtBuscar.Text;
            c.buscarProducto(dgProductos, bus);
        }
    }
}
