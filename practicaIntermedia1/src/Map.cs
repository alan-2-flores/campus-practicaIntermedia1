using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaIntermedia1.src
{
    public class Map<T> where T: Pair
    {
        //key 1
        //value algo
        private readonly T[] arreglo = new T[100];

        public void Put(int i, T obj)
        {
           arreglo[i] = obj;
        }

        public T GetAt(int i)
        {
            return arreglo[i];
        }

        public T Get(string key)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] != null && arreglo[i].Key == key) {
                    return arreglo[i];
                }
            }
            return null;
        }
    }
}
