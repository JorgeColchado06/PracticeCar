using System;
using System.Runtime.Intrinsics.X86;

namespace PracticeCar;
internal class Program
{
    private static void Main(string[] args)
    {


        //Instancias de autos
        Vehicle FordFusion = new Vehicle();
        FordFusion.Year = new DateOnly(2016, 07, 06);
        FordFusion.Type = "A";
        FordFusion.Brand = "Ford";
        FordFusion.Description = "The best option to drive";
        FordFusion.Wheels = "Michellin";
        FordFusion.Color = "Gris";

        Vehicle Vochido = new Vehicle();
        Vochido.Year = new DateOnly(2021, 01, 29);
        Vochido.Type = "A";
        Vochido.Brand = "Volkswagen";
        Vochido.Description = "No c pa no tengo uno";
        Vochido.Wheels = "Firestone";
        Vochido.Color = "Rojo";

        Vehicle Rav4 = new Vehicle();
        Rav4.Year = new DateOnly(2012, 02, 15);
        Rav4.Type = "A";
        Rav4.Brand = "Toyota";
        Rav4.Description = "Camioneta Belicona";
        Rav4.Wheels = "Firelli";
        Rav4.Color = "Azul";

        Vehicle MercedesBenzClaseA = new Vehicle();
        MercedesBenzClaseA.Year = new DateOnly(2021, 09, 10);
        MercedesBenzClaseA.Type = "A";
        MercedesBenzClaseA.Brand = "MercedezBenz";
        MercedesBenzClaseA.Description = "Carros de Fresas";
        MercedesBenzClaseA.Wheels = "BBS";
        MercedesBenzClaseA.Color = "Blue";

        Vehicle Lobo15080 = new Vehicle();
        Lobo15080.Year = new DateOnly(2022, 11, 22);
        Lobo15080.Type = "A";
        Lobo15080.Brand = "Ford";
        Lobo15080.Description = "Trocona pal Rancho";
        Lobo15080.Wheels = "Firestone";
        Lobo15080.Color = "Naranja";




        //Instacias personas
        Person Person = new Person();
        //Person usuario1 = Person.createPerson(001, "Jorge", "Colchado", 19, "Boy");
        //Person usuario2 = Person.createPerson(002, "Ruth", "Castillo", 22, "Girl");
        //Person usuario3 = Person.createPerson(003, "Michelle", "Vazquez", 90, "Girl");
        Person usuario4 = Person.createPerson(003, "Carlos", "Mora", 22, "Boy");


        //Console.WriteLine("----What is your name?----");
        //string name = Console.ReadLine();
        //Person.Name = name;
        //Console.WriteLine("----What is your surname?----");
        //string Surname = Console.ReadLine();
        //Person.Surname = Surname;
        //Console.WriteLine("----How old are you?----");
        //int year = Convert.ToInt32(Console.ReadLine());
        //Person.Year = year;
        //Console.WriteLine("----What is your gender?----");
        //string Gender = Console.ReadLine();
        //Person.Gender = Gender;
        //Console.WriteLine("----What is your keycode?----");
        //int KeyCode = Convert.ToInt32(Console.ReadLine());



        //Instancias de Licencias
        License license = new License();
        License A01 = license.createLicense("A", new DateOnly(2021, 05, 06), new DateOnly(2023, 05, 06));

        License A02 = license.createLicense("A", new DateOnly(2021, 12, 02), new DateOnly(2022, 12, 02));

        License B03 = license.createLicense("B", new DateOnly(2019, 12, 25), new DateOnly(2020, 12, 25));

        License B04 = license.createLicense("B", new DateOnly(2022, 08, 30), new DateOnly(2024, 12, 25));

        //Entering data

        //usuario1.giveCar(Rav4);

        //usuario1.giveLicense(A01);

        //Console.WriteLine("-----Usuario 1-------");
        //Person.printUserData(usuario1);
        //usuario1.printLicenses();
        //usuario1.printCars();



        //usuario1.cancelCar(Rav4);
        //usuario1.printCars();

        //


        //usuario2.giveCar(MercedesBenzClaseA);

        //usuario2.giveLicense(A01);

        //Console.WriteLine("-----Usuario 2-------");
        //Person.printUserData(usuario2);
        //usuario2.printLicenses();
        //usuario2.printCars();



        //usuario2.cancelCar(MercedesBenzClaseA);
        //usuario2.printCars();

        //

        //usuario3.giveCar(Vochido);

        //usuario3.giveLicense(A01);


        //Console.WriteLine("-----Usuario 3-------");
        //Person.printUserData(usuario3);
        //usuario3.printLicenses();
        //usuario3.printCars();



        //usuario3.cancelCar(Vochido);
        //usuario3.printCars();

        //

        usuario4.giveCar(Vochido,FordFusion,Rav4,MercedesBenzClaseA,Lobo15080);

        usuario4.giveLicense(A01);


        Console.WriteLine("-----Usuario 4-------");
        Person.printUserData(usuario4);
        usuario4.printLicenses();
        usuario4.printCars();



        usuario4.cancelCar(Vochido);
        usuario4.printCars();










        Console.WriteLine(Person);

    }




}