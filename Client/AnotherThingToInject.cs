using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCustomAuth5.Client
{
    public class AnotherThingToInject
    {
        private readonly string _id = Guid.NewGuid().ToString();
        public AnotherThingToInject()
        {
            Console.WriteLine($"Created AnotherThing: {_id}");
        }
    }
}
