using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReservationSystemWEB
{
    public class DatabaseCommands
    {/*
        public bool DeleteRecord(LinqToSQLDataContext db, string email, string surname)
        {
            var deleteOrderDetails =
                from details in db.Reservation
                 where details.Email == email
                where details.Surname == surname
                select details;

            foreach (var detail in deleteOrderDetails)
            {
                db.Reservation.DeleteOnSubmit(detail);
            }

            try
            {
                db.SubmitChanges();
                return true;
            }
            catch (Exception t)
            {
                Console.WriteLine(t);
                return false;
                // Provide for exceptions.
            }
        }

        public void InsertRecord(LinqToSQLDataContext db, int id, string name, string surname, string email, string telNumber)
        {
            Reservation newReservation = new Reservation()
            {
                ID = id,
                Name = name,
                Surname = surname,
                Email = email,
                MobileNumber = telNumber
            };

            db.Reservation.InsertOnSubmit(newReservation);

            // Submit the change to the database.
            try
            {
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        */
    }
}