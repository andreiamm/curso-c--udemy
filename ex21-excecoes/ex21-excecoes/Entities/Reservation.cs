using ex21_excecoes.Entities.Exceptions;
using System;

namespace ex21_excecoes.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkIn >= checkOut)
            {
                throw new DomainException("Check-out date must be after check-in date.");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            if (checkIn >= checkOut)
            {
                throw new DomainException("Check-out date must be after check-in date.");
            }
            if (checkIn < DateTime.Now || checkOut < DateTime.Now)
            {
                throw new DomainException("Reservation dates for update must be future dates.");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return  $"Room {RoomNumber}, " +
                    $"check-in: {CheckIn.ToString("d")}, " +
                    $"check-out: {CheckOut.ToString("d")}, " +
                    $"{Duration()} nights.";
        }
    }
}
