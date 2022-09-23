using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCar
{
    internal class Vehicle
    {
        public string? Type { get; set; }
        public DateOnly Year { get; set; }
        public string? Brand { get; set; }
        public string? Description { get; set; }
        public string? Wheels { get; set; }
        public string? Color { get; set; }


        public Vehicle CustomizeCar(DateOnly date, string brandParameter, string wheelsParameter, string color, string descriptionParameter, string typeParameter)
        {
            Vehicle carCustom = new Vehicle();
            carCustom.Year = date;
            carCustom.Brand = brandParameter;
            carCustom.Wheels = wheelsParameter;
            carCustom.Color = color;
            carCustom.Description = descriptionParameter;
            carCustom.Type = typeParameter;

            return carCustom;




        }
        public void cancelCar()
        {

        }

    }
}
