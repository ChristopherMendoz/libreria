using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public  class Libro
    {
        
        int  total;
        string cliente;
        string Producto;
        double pago;

        int ISBN;
        string titulo ;
        string autor ;
        int NPag;
        double precio;
        int CantAlmac;

        public Libro()
        {
        }

        public Libro(int iSBN, int cantAlmac)
        {
            ISBN = iSBN;
            CantAlmac1 = cantAlmac;
        }

        public Libro(double precio)
        {
            this.Precio = precio;
        }

        public Libro( string titulo, string autor, int nPag)
        {
         
            this.titulo = titulo;
            this.autor = autor;
            NPag = nPag;
        }

        public Libro(int total, string cliente, string producto, double pago)
        {
            this.Total = total;
            this.Cliente = cliente;
            Producto1 = producto;
            this.Pago = pago;
        }

        public string Titulo 
        { 
            get => titulo; 
            set => titulo = value;
        }
        public string Autor
        {
            get => autor;
            set => autor = value; 
        }
        public int NPag1 
        {
            get => NPag;
            set => NPag = value;
        }
        public int ISBN1 { get => ISBN; set => ISBN = value; }
        public double Precio { get => precio; set => precio = value; }
        public int CantAlmac1 { get => CantAlmac; set => CantAlmac = value; }
        public int Total { get => total; set => total = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public string Producto1 { get => Producto; set => Producto = value; }
        public double Pago { get => pago; set => pago = value; }

        public string Mostrar(string titulo,string ISBN,string Autor,String Npag)
        {
            string mostrar;
            mostrar = "El Libro: " + titulo+" Con ISBN " + ISBN + " Del autor: " + Autor+" tiene " + Npag + " paginas.";
            return mostrar;
        }
    }
}
