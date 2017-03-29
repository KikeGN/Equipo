using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows.Forms;

namespace CLOTHWARE
{
    class clsConexion
    {
      MySqlConnection conexion = new MySqlConnection("server=localhost; database=tienda; user=root; password=root");
        public void openConexion()
        {
            conexion.Open();

        }
        public void comprobarConexion()
        {
            try
            {
                openConexion();
                MessageBox.Show("LA CONEXION FUE COMPLETADA CORRECTAMENTE!");
                closeConexion();
            }
            catch
            {
                MessageBox.Show("SE PRODUJO UN ERROR EN LA CONEXION");
            }

        }
        public void closeConexion()
        {
            conexion.Close();
        }

    }
}
