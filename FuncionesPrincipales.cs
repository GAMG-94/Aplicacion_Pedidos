using Libreria_Pedidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Pedidos
{
    public static class FuncionesPrincipales
    {

        //Clientes
        public static void EjemploCliente()
        {
            clsClientes cliente;

            cliente = new clsClientes();

            cliente.idCliente = 1;
            cliente.NombreCompleto = "Geovanny Mesa";
            cliente.Rfc = "HO76534";

            Console.WriteLine(cliente.ToString());
        }

        //Productos
        public static void EjemploRecordProducto()
        {
            clsProductos Producto = new clsProductos();
            Producto.Id = 1;
            Producto.Descripcion = "REF GASEOSA PEPSI";
            Producto.CodigoBarras = "0001";

            clsProductos Producto2 = new clsProductos();
            Producto2 = Producto;

            recProductos rProductos = new recProductos(1, "REF GASEOSA PEPSI", "01");
            recProductos rProductos2 = rProductos with { CodigoBarras = "0" };

            Console.WriteLine("Producto; " + Producto);
            Console.WriteLine("Producto2; " + Producto2);
            Console.WriteLine("rProducto; " + rProductos);
            Console.WriteLine("rProducto2; " + rProductos2);

            if (Producto == Producto2)
                Console.WriteLine("Los Objetos son iguales");
            else
                Console.WriteLine("Los objetos son diferentes");


            if (rProductos == rProductos2)
                Console.WriteLine("Los registros son iguales");
            else
                Console.WriteLine("Los registros son diferentes");
        }

        public static void EjemploDesglosaImpuestos()
        {
            clsProductosPrecios Producto = new clsProductosPrecios();
            Producto.PrecioPublico = 17.5m;
            Producto.PrecioMayor = 15;
            Producto.PorcentajeIva = 19;
            Producto.PorcentajeIeps = 8;
            decimal precioSinImpuestos, MontoIva = 0, MontoIeps = 0;
            Console.WriteLine(Producto + "\n");
            recMontosImpuestos Montos = new recMontosImpuestos(0, 0);
            precioSinImpuestos = Producto.DesglosaImpuestos(Montos);
            Console.WriteLine(precioSinImpuestos.ToString("C") + "\n");
            Console.WriteLine(Montos.ToString());
        }
    }
}
