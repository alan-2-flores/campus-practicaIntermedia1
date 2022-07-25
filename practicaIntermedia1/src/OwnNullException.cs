using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaIntermedia1.src
{
    public class OwnNullException:NullReferenceException
    {
        public OwnNullException():base()
        {
            Console.WriteLine("El valor es nulo");
        }
    }
}
