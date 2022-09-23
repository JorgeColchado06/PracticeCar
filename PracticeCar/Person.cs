using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace PracticeCar
{
    internal class Person
    {

        public DateOnly today = new DateOnly(2022, 09, 14);
        public int KeyCode { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int Year { get; set; }
        public string? Gender { get; set; }

        List<License> LicenseSet = new List<License>();
        List<Vehicle> VehicleSet = new List<Vehicle>();

        public bool supiciousOfFraud = false;

        //License first time check
        public bool firstLicense = true;

        //Last license
        public DateOnly lastLicense { get; set; }

        //Varible to count
        private int counter = 0;
        private int counterCar = 0;

        //Methods
        public void receiveLicense(License licenseMethod)
        {
            LicenseSet.Add(licenseMethod);
        }
        public void receiveCar(Vehicle carMethod)
        {
            VehicleSet.Add(carMethod);
        }
        public bool quitCar(Vehicle cars)
        {
            foreach (Vehicle vehicle in VehicleSet)
            {
                if (cars == vehicle)
                {
                    VehicleSet.Remove(cars);
                    return true;
                }

            }
            return false;
        }
        public int carCounter()
        {
            counterCar = VehicleSet.Count;
            return counterCar;
        }

        public bool validLicense()
        {
            for (int i = 0; i < LicenseSet.Count; i++)
            {
                if (today < LicenseSet[i].ExpirationDate)
                {
                    return true;
                }
            }

            return false;
        }

        public bool licenseGet(string type)
        {
            for (int i = 0; i < LicenseSet.Count; i++)
            {
                if (LicenseSet[i].Type == type)
                {

                    if (true == validLicense())
                    {
                        return true;
                    }
                }
            }
            Console.WriteLine("No tienes licencia de TIPO vigente ");
            return false;
        }

        public Person createPerson(int keyCodeParameter, string NameParameter, string surNameParameter, int ageParameter, string genderParameter)
        {
            Person personCustom = new Person();
            personCustom.KeyCode = keyCodeParameter;
            personCustom.Name = NameParameter;
            personCustom.Surname = surNameParameter;
            personCustom.Year = ageParameter;
            personCustom.Gender = genderParameter;
            return personCustom;
        }


        //Printer functions
        public void printUserData(Person people)
        {
            Console.WriteLine("\n" + "Especificaciones del usario:" + "\n");
            Console.WriteLine("Key Code: " + people.KeyCode + "\n" +
                "Name: " + people.Name + "\n" +
                "SurName: " + people.Surname + "\n" +
                "Age: " + people.Year + "\n" +
                "Gender: " + people.Gender + "\n");
        }
        public void printLicenses()
        {
            Console.WriteLine("Las siguientes LICENCIAS son de " + Name + "\n");
            counter = 0;
            if (LicenseSet.Count == 0)
            {
                Console.Write("Vacio, no cuentas con ninguna LICENCIA" + "\n" + "\n");
            }
            foreach (License license in LicenseSet)
            {
                counter++;
                Console.WriteLine("License Number: " + counter + "\n" + "Type: " + license.Type + "\n" + "Initial Date: " + license.InitialDate + "\n" + "Expiration date: " + license.ExpirationDate + "\n" + "Key code: " + license.KeyCode + "\n");
            }
        }

        public void printCars()
        {
            Console.WriteLine("Los siguientes Autos son de " + Name + "\n");
            counter = 0;
            if (VehicleSet.Count == 0)
            {
                Console.Write("Vaco, no tienes ningun auto" + "\n" + "\n");
            }
            foreach (Vehicle car in VehicleSet)
            {
                counter++;
                Console.WriteLine("Car Number " + counter + "\n" + "Brand: " + car.Brand + "\n" + "Year :" + car.Year + "\n" + "Wheels: " + car.Wheels + "\n" + "Color: " + car.Color + "\n" + "Car type: " + car.Type + "\n" + "A brief description: " + car.Description + "\n");
            }
        }


        //Functions
        //Instancia de la fecha (today)
        License date = new License();

        //Darle a la gente sus licencias y vehiculos
        public void giveLicense(License license)
        {
            if (Year >= 90) //Checador de edad
            {
                Console.WriteLine("\n" + "--------- Lo sentimos, no podemos proporcionar una licencia a un anciano -----------" + "\n");
            }
            else
            {
                if (firstLicense == true)
                {
                    receiveLicense(license);
                    license.KeyCode = KeyCode; //establecer el último parámetro a la licencia
                    firstLicense = false;
                    lastLicense = license.ExpirationDate;
                }
                else
                {
                    if (lastLicense > date.today) //comparar para saber si las licencias son capaces de cambiar (parámetro)
                    {
                        Console.WriteLine("\n" + "----------- No se puede activar una nueva licencia teniendo una vigente  ------------" + "\n");
                    }
                    else
                    {
                        receiveLicense(license);
                        lastLicense = license.ExpirationDate;
                    }
                }

            }
        }

        public void giveCar(Vehicle car)
        {
            if (Gender == "Girl")
            {
                if (car.Color == "Red")
                {
                    receiveCar(car);
                }
                else
                {
                    Console.WriteLine("\n" + "--------- A las chicas no les gustan los coches que no son rojos  ----------" + "\n");
                }
            }
            else
            {
                if (car.Brand == "Ford" || car.Brand == "Toyota")
                {
                    receiveCar(car);
                }
                else
                {
                    Console.WriteLine("\n" + "--------- PREFERENCIA: A los chicos no les gustan otros coches que no sean ford o toyota ------------" + "\n");
                }
            }
            if (carCounter() >= 5)
            {
                supiciousOfFraud = true;
            }
        }
        public void cancelCar(Vehicle car)
        {
            if (car.Type == "A")
            {
                //compruebe la FECHA DE VALIDACIÓN y el MISMO TIPO de licencia comparando con el coche
                if (licenseGet("A") == true)
                {
                    if (quitCar(car) == true)
                    {
                        Console.WriteLine("Car " + car.Brand + " quitted to " + Name + " succesfully!");
                    }
                    else
                    {
                        Console.WriteLine("\n" + "------- Function error: Car " + car.Brand + " didn't found on " + Name + " to quit :( -----------" + "\n");
                    }
                }
                else
                {
                    Console.WriteLine("\n" + "-------- Function error: You cannot cancel " + car.Brand + " without a valid license ------" + "\n");
                }
            }
            else if (car.Type == "B")
            {
                if (licenseGet("B") == true)
                {
                    if (quitCar(car) == true)
                    {
                        Console.WriteLine("\n" + "Car " + car.Brand + " quitted to " + Name + " succesfully!" + "\n");
                    }
                    else
                    {
                        Console.WriteLine("\n" + "------ Function error: Car" + car.Brand + "didn't found on " + Name + " to quit :( -------" + "\n");
                    }
                }
                else
                {
                    Console.WriteLine("\n" + "-------- Error de funcionamiento: No se puede cancelar el coche " + car.Brand + " sin una licencia válida ----------" + "\n");
                }
            }

            else if (car.Type == "C")
            {
                if (licenseGet("C") == true)
                {
                    if (quitCar(car) == true)
                    {
                        Console.WriteLine("\n" + "Car " + car.Brand + " quitted to " + Name + " succesfully!" + "\n");
                    }
                    else
                    {
                        Console.WriteLine("\n" + "------ Function error: Car" + car.Brand + "didn't found on " + Name + " to quit :( -------" + "\n");
                    }
                }
                else
                {
                    Console.WriteLine("\n" + "-------- Function error: You cannot cancel car " + car.Brand + " without a valid license :( ----------" + "\n");
                }
            }
            else
            {
                Console.WriteLine("\n" + "---------- There is a problem, you don't have that car-----------" + "\n");
            }



        }



    }
}
