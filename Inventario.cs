using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_De_Inventario
{
    class Inventario
    {
        static private string[] productos = new string[20];

        static private string _cantidad;
        public string cantidad { get { return _cantidad; } }


        public void agregar(string nombre)
        {
            int i=0;
            while (productos[i] != null)
                i++;
            _cantidad = toString(i+1);
            productos[i] = nombre;
        }

        public void eliminar(string nombre)
        {
            int i = 0, n=0;
            for (i = 0; n<1 && i<20; i++)
                if(nombre == productos[i])
                {
                    productos[i] = null;
                    n++;
                }
            corrimiento();
            i = 0;
            while (productos[i] != null)
                i++;
            _cantidad = toString(i);
        }

        public string toString(int cantidad)
        {
            string cadena = "No. de productos: " + Convert.ToString(cantidad);
            return cadena; 
        }

        public void corrimiento()
        {
            int n = 0;
            for (int i = 0; i < productos.Length && n<1; i++)
            {
                if (productos[i] == null)
                {
                    productos[i] = productos[i + 1];
                    productos[i + 1] = null;
                    n++;
                }
            }
        }

        public void insertar (string nombre,int pos)
        {
            productos[pos] = nombre;
        }
    }
}
