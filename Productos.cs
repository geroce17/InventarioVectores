using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_De_Inventario
{
    class Productos:Inventario
    {
        static private string[,] listado = new string[20, 4];


        public void agregadoFull(string nombre, string codigo, string cantidad, string costo)
        {
            int r=0, c=0;
            for (r = 0; r < 20; r++)
                for (c = 0; c < 4;c++)
                    if(listado[r, c]==null)
                    {
                        listado[r, c] = nombre; c++;
                        listado[r, c] = codigo; c++;
                        listado[r, c] = cantidad; c++;
                        listado[r, c] = costo; c++;
                        r = 19;
                        c = 3;
                    }
            agregar(nombre);
        }


        public void eliminarFull(string nombre)
        {
            int r = 0, c = 0;
            for (r = 0; r < Math.Sqrt(listado.Length); r++)
                if (listado[r, c] == nombre)
                    break;
                    for (c = 0; r < Math.Sqrt(listado.Length); c++)
                    if (listado[r, c] == nombre)
                        break;
            while (c < 4)
            {
                listado[r, c] = null;
                c++;
            }
            eliminar(nombre);
        }

        public string buscar(string nombre)
        {
            int r = 0, c = 0, n=0;
            string cadena="";
            for (r = 0; r < 20 && n<1; r++)
                if (listado[r, c] == nombre)
                {
                    cadena = listado[r, 1] + "\r\n" + listado[r, 0] + "\r\n" + listado[r, 2] + "\r\n" + listado[r, 3];
                    n++;
                }

            return cadena;
        }

        public string reporte()
        {
            int r = 0;
            string cadena = "";
            for (r = 0; r < 20; r++)
            {
                if(listado[r,0]!=null)
                    cadena += "Codigo: " + listado[r, 1] + "\r\nNombre: " + listado[r, 0] + "\r\nPrecio: " + listado[r, 2] + "\r\nCantidad: " + listado[r, 3] + "\r\n \r\n";
            }

            return cadena;
        }

        public void insertarFull (string nombre, string codigo, string cantidad, string costo, int pos)
        {
            int i = 0;
            listado[pos, i] = nombre;i++;
            listado[pos, i] = codigo;i++;
            listado[pos, i] = cantidad;i++;
            listado[pos, i] = costo;

            insertar(nombre, pos);
        }
    }
}
