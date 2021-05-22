using System;
using System.Collections;

namespace RepeatInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            CallMethod callMethod = new CallMethod();

            Chopper chopper = new Chopper
            {
                Id = 2,
                Name = "Test2",
                WhereYouLive = "Los Angels"
            };

            Chopper chopper1 = new Chopper
            {
                Id = 1,
                Name = "Test",
                WhereYouLive = "Miami days"
            };

            callMethod.Print(chopper1);
            Console.WriteLine("\n");
            callMethod.Print(chopper);


        }
    }

    interface IChopper
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string WhereYouLive { get; set; }
    }

    class Chopper:IChopper
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string WhereYouLive { get; set; }
    }

    class CallMethod
    {
        public void Print(Chopper chopper)
        {
            Console.WriteLine(chopper.Id);
            Console.WriteLine(chopper.Name);
            Console.WriteLine(chopper.WhereYouLive);
        }
    }
}
