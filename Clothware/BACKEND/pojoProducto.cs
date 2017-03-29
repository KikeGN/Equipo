using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clothware.BACKEND
{
    class pojoProducto
    {
        string  modelo, talla, color,tela,descripcion;
        int existencia, id,alta;
        double precio;

        public pojoProducto(int id, string modelo,string talla, string color, int existencia, string tela, string descripcion,
            double precio,int stat)
        {
            this.id = id;
            this.modelo = modelo;
            this.talla = talla;
            this.color = color;
            this.existencia = existencia;
            this.tela = tela;
            this.descripcion = descripcion;
            this.precio = precio;
            this.alta = stat;
        }
       
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public string Talla
        {
            get { return talla; }
            set { talla = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public int Existencia
        {
            get { return existencia; }
            set { existencia = value; }
        }

        public string Tela
        {
            get { return tela; }
            set { tela = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio= value; }
        }

        public int Alta
        {
            get { return alta; }
            set { alta = value; }
        }

    }
}
