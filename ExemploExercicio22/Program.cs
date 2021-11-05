﻿using System;
using System.Globalization;
using ExemploInterfaces01.Entities;
using ExemploInterfaces01.Services;

namespace ExemploInterfaces01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            System.Console.Write("Car model: ");
            string model = Console.ReadLine();
            System.Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            System.Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            System.Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            System.Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start,finish,new Vehicle(model));

            RentalService rentalService = new RentalService(hour,day,new BrazilTaxService());       

            rentalService.ProcessInvoice(carRental);

            System.Console.WriteLine("INVOICE: ");
            System.Console.WriteLine(carRental.Invoice);

        }
    } 
}
