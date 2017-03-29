using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows.Forms;
using Clothware.BACKEND;
using Clothware.FRONTEND;
using System.Data;

namespace Clothware.BACKEND
{
    class conexion
    {
        string cadenaConexion = "server=localhost; database=TIENDA; uid=root; pwd=root";
        MySqlConnection conexxion = new MySqlConnection();
        MySqlDataReader res;



        public void cargartodosdatosproductos(DataGridView grid)
        {
            conexxion.ConnectionString = cadenaConexion;
            try
            {
                conexxion.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("select * from productos", conexxion);
                DataSet ds = new DataSet();
                da.Fill(ds, "productos");
                grid.DataSource = ds;
                grid.DataMember = "productos";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexxion.Close();
            }
        }



        public void agregarProducto(pojoProducto producto)
        {
            conexxion.ConnectionString = cadenaConexion;
            List<pojoProducto> prod = new List<pojoProducto>();
            try
            {
                conexxion.Open();

                //id modelo talla color existencia tela descripcion precio
                MySqlCommand dr = new MySqlCommand("insert into productos values(@id,@mod,@tall,@col,@exist,@tel,@desc,@prec,@alt)", conexxion);
                dr.Parameters.AddWithValue("@id", producto.Id);
                dr.Parameters.AddWithValue("@mod", producto.Modelo);
                dr.Parameters.AddWithValue("@tall", producto.Talla);
                dr.Parameters.AddWithValue("@col", producto.Color);
                dr.Parameters.AddWithValue("@exist", producto.Existencia);
                dr.Parameters.AddWithValue("@tel", producto.Tela);
                dr.Parameters.AddWithValue("@desc", producto.Descripcion);
                dr.Parameters.AddWithValue("@prec", producto.Precio);
                dr.Parameters.AddWithValue("@alt", producto.Alta);

                dr.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexxion.Close();

            }
        }

        public void editarProducto(pojoProducto producto)
        {
            conexxion.ConnectionString = cadenaConexion;
            List<pojoProducto> prod = new List<pojoProducto>();
            try
            {
                conexxion.Open();

                //id modelo talla color existencia tela descripcion precio
                MySqlCommand dr = new MySqlCommand("update  productos set modelo = @mod, talla = @tall, color = @col,existencia = @exist, tela = @tel, descripcion = @desc, precio = @prec, alta = @alt where idProducto = @id;", conexxion);
                dr.Parameters.AddWithValue("@id", producto.Id);
                dr.Parameters.AddWithValue("@mod", producto.Modelo);
                dr.Parameters.AddWithValue("@tall", producto.Talla);
                dr.Parameters.AddWithValue("@col", producto.Color);
                dr.Parameters.AddWithValue("@exist", producto.Existencia);
                dr.Parameters.AddWithValue("@tel", producto.Tela);
                dr.Parameters.AddWithValue("@desc", producto.Descripcion);
                dr.Parameters.AddWithValue("@prec", producto.Precio);
                dr.Parameters.AddWithValue("@alt", producto.Alta);

                dr.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexxion.Close();

            }
        }
        public void buscarProducto(DataGridView grid,string busqueda)
        {
            conexxion.ConnectionString = cadenaConexion;
            try
            {
                conexxion.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("select * from productos where idProducto="+"'"+busqueda+"';", conexxion);
                DataSet ds = new DataSet();
                da.Fill(ds, "productos");
                grid.DataSource = ds;
                grid.DataMember = "productos";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexxion.Close();
            }
        }





    }
}
