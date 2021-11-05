using System;
using Exercicio01.Entities;
using Exercicio01.Entities.Exeptions;


namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                System.Console.Write("Check-in date (dd/MM/yyyy)");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                System.Console.Write("Check-out date (dd/MM/yyyy)");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);
                System.Console.WriteLine("Reservation: " + reservation);

                System.Console.WriteLine("\n Enter data to update the reservation:");
                System.Console.Write("Check-in date (dd/MM/yyyy)");
                checkIn = DateTime.Parse(Console.ReadLine());
                System.Console.Write("Check-out date (dd/MM/yyyy)");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                System.Console.WriteLine("Reservation: " + reservation);
            }
            catch (DomainExceptions e)
            {
                System.Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch (FormatException e)
            {
                System.Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
