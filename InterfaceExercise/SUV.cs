using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    class SUV : IVehicle, ICompany
    {
        public string Make { get ; set; }
        public string Model { get ; set; }
        public string Year { get ; set; }
        public string Logo { get ; set; }
        public DateTime Established { get; set; }
        


        public void Drive()
        {
            Console.WriteLine("SUV is driving");


        }
    }
}
