
namespace GraspConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IChoosable buyedCar = Distributor.getChoosenTransport(ETransportationType.Convertible);
            System.Console.WriteLine(buyedCar.Buy());

            buyedCar = Distributor.getChoosenTransport(ETransportationType.Sedan);
            System.Console.WriteLine(buyedCar.Buy());

            buyedCar = Distributor.getChoosenTransport(ETransportationType.Truck);
            System.Console.WriteLine(buyedCar.Buy());

            buyedCar = Distributor.getChoosenTransport(ETransportationType.Mountainbike);
            System.Console.WriteLine(buyedCar.Buy());

            System.Console.ReadLine();
        }
    }
}

