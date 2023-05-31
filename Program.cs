global using Aplicacion_Pedidos;
global using Libreria_Pedidos;

int opcion = 0;

do{
    Console.WriteLine("Menú de Opciones: \n");
    Console.WriteLine("1. Ejemplo de Clientes");
    Console.WriteLine("2. Ejemplo de Productos");
    Console.WriteLine("3. Ejemplo de paso de Parámetros a un Método");
    Console.WriteLine("4. Salir");
    opcion = Convert.ToInt32(Console.ReadLine()); //Parseando la opción ingresada por el usuario

    switch (opcion)
    {
        case 1:
            FuncionesPrincipales.EjemploCliente();
            break;
        case 2:
            FuncionesPrincipales.EjemploRecordProducto();
            break;
        case 3:
            FuncionesPrincipales.EjemploDesglosaImpuestos();
            break;
        default:
            break;
    }


} while (opcion != 4);

