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
        Vochido.Year = new DateOnly(2010, 01, 29);
        Vochido.Type = "B";
        Vochido.Brand = "Volkswagen";
        Vochido.Description = "No c pa no tengo uno";
        Vochido.Wheels = "Firestone";
        Vochido.Color = "Rojo";

        Vehicle Rav4 = new Vehicle();
        Rav4.Year = new DateOnly(2012, 02, 15);
        Rav4.Type = "C";
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
        MercedesBenzClaseA.Color = "Rojo";

        Vehicle Lobo15080 = new Vehicle();
        Lobo15080.Year = new DateOnly(2022, 11, 22);
        Lobo15080.Type = "C";
        Lobo15080.Brand = "Ford";
        Lobo15080.Description = "Trocona pal Rancho";
        Lobo15080.Wheels = "Firestone";
        Lobo15080.Color = "Naranja";





        Console.WriteLine("Hello, World!");
    }
}