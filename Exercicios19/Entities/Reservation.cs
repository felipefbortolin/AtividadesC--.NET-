using System;
using Exercicio01.Entities.Exeptions;

namespace Exercicio01.Entities
{
    class Reservation
    {
        public Reservation()
        {
        }

        public Reservation(int roomNumer, DateTime checkIn, DateTime checkOut)
        {
            if (checkIn >= checkOut)
            {
                throw new DomainExceptions("Check-out date must be after check-in date");
            }
            RoomNumer = roomNumer;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int RoomNumer { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                throw new DomainExceptions("Reservation dates for updates must be future dates");
            }
            if (checkIn >= checkOut)
            {
                throw new DomainExceptions("Check-out date must be after check-in date");
            }
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public override string ToString()
        {
            return "Room"
            + RoomNumer
            + ", check-in: "
            + CheckIn.ToString("dd/MM/yyyy")
            + ", check-out: "
            + CheckOut.ToString("dd/MM/yyyy")
            + ", "
            + Duration()
            + " nights";
        }
    }
}
