using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCar
{
    internal class Person
    {

        public DateOnly today = new DateOnly(2022, 09, 14);
        public int KeyCode { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int Age { get; set; }
        public string? gender { get; set; }

        List<System.ComponentModel.License> LicenseSet = new List<System.ComponentModel.License>();
        List<Vehicle> VehicleSet = new List<Vehicle>();

        public bool supiciousOfFraud = false;



    }
}
