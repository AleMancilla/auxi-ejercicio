using System;

namespace Auxi
{
    class Program
    {
        static void Main(string[] args)
        {
            //####### insiso A #######
            Console.WriteLine("\n###########   inciso a #############\n");

            ConcursoBar<int> concurso1 = new ConcursoBar<int>();
            ConcursoBar<string> concurso2 = new ConcursoBar<string>();

            Pareja<int> pareja1 = new Pareja<int>("Alexander","Mari","Salsa");
            Pareja<string> pareja2 = new Pareja<string>("Nelson","La Toxica","Bachata");

            Presentacion<int> Presentacion1 = new Presentacion<int>("UMSA","16/06/2020");
            Presentacion1.agregarPareja(pareja1);

            Presentacion<string> Presentacion2 = new Presentacion<string>("UPEA","27/06/2020");
            Presentacion2.agregarPareja(pareja2);

            concurso1.agregarPresentacion(Presentacion1);
            concurso2.agregarPresentacion(Presentacion2);


            concurso1.mostrarPresentacion();
            concurso2.mostrarPresentacion();

            // insiso b

            Console.WriteLine("\n###########   inciso b #############\n");
            
            Pareja<string> pareja22 = new Pareja<string>("Alex","Juana","Bachata");
            Pareja<string> pareja222 = new Pareja<string>("Rodrigo","Maria","Bachata");

            Calf<string> calificacion1 = new Calf<string>("LIC. HUANCA","Pesimo");
            Calf<string> calificacion2 = new Calf<string>("LIC. Sanches","Excelente");
            Calf<string> calificacion3 = new Calf<string>("LIC. Rick","Excelente");

            pareja2.agregarCalificacion(calificacion1);
            pareja2.agregarCalificacion(calificacion2);
            pareja2.agregarCalificacion(calificacion3);

            pareja22.agregarCalificacion(calificacion1);
            pareja222.agregarCalificacion(calificacion2);


            concurso2.mostrarPesimos();

            // insiso c
            Console.WriteLine("\n###########   inciso c #############\n");
            concurso1.eliminarPareja("Alexander","Mari","16/06/2020");
            concurso1.mostrarPresentacion();




        }
    }
}
