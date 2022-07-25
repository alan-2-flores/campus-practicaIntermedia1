using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practicaIntermedia1.src;

namespace practicaIntermedia1
{
    internal class Program
    {
        static void Main()
        {
            //parte 1
            int aleatorio = new Random().Next(0, 1000);
            string ternario = aleatorio > 500 ? "Greater than 500" : "Less than 500";
            Console.WriteLine(ternario + "\nel numero es:" + aleatorio);
            Console.ReadKey();

            //parte 2
            try
            {
                int? nullable;
                string mensaje;
                nullable = null;
                mensaje = nullable == null ? throw new OwnNullException() : "el valor es valido";
                Console.WriteLine(mensaje);
            }
            catch (OwnNullException nullExeption)
            {
                Console.WriteLine(nullExeption);
            }
            Console.ReadKey();

            //parte 3
            var persona = new { Name = "Alan", Age = 22};
            Console.WriteLine($"Nombre: {persona.Name}");
            Console.WriteLine($"Edad: {persona.Age}");

            dynamic dinamico = 42;
            Console.WriteLine(dinamico+5);
            dinamico = "AlanWasHere";
            Console.WriteLine(dinamico);

            dinamico = new { Name = "Patrick", Age = 4, Especie="Emperador" };
            Console.WriteLine($"Nombre: {dinamico.Name}, Edad: {dinamico.Age}, Especie: Pinguino {dinamico.Especie}");
            Console.ReadKey();

            //parte 4
            var objMap = new Map<Pair>();
            objMap.Put(0, new Objeto("ID123", "valor"));
            objMap.Put(1, new Objeto("ID124", "valor1"));
            objMap.Put(2, new Objeto("ID125", "valor2"));

            try
            {
                Console.WriteLine($"GETAT() LLAVE: {objMap.GetAt(1).Key} VALOR: {objMap.GetAt(1).Value}");
                Console.ReadKey();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                Console.ReadKey();
            }

            try
            {
                var busqueda = objMap.Get("ID128");
                if(busqueda != null)
                Console.WriteLine($"GET() LLAVE: {busqueda.Key} VALOR: {busqueda.Value}");
                else
                    Console.WriteLine("GET() No hubo coincidencias");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }

            //parte 5
            Console.WriteLine($"EXTENSION LLAVE: {EMap.PrimerValor(objMap).Key} VALOR: {EMap.PrimerValor(objMap).Value}");
            Console.ReadKey();

            //parte 6
            if (EMap.ValidaTexto("Aqwe1234"))
                Console.WriteLine("texto valido");
            else
                Console.WriteLine("texto invalido");

            Console.ReadKey();

        }
        //parte 4
        public class Objeto : Pair
        {
            public Objeto(string key, dynamic value)
            {
                Key = key;
                Value = value;
            }

            public override string Key { get; set; }
            public override dynamic Value { get; set; }
        }
    }
}
