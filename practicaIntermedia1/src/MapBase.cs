namespace practicaIntermedia1.src
{
    public class MapBase
    {
        public T[] CrearArreglo<T>(T elemento1, T elemento2)
        {
            return new T[] { elemento1, elemento2 };
        }
    }
}