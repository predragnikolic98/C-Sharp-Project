using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;




namespace ReservationAPI.Controllers
{

    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<Reservation> Get()
        {   
            using (var db = new LingToSqlDataContext())
            {
                var reservation  = (from details in db.Reservation
                                                  select details);

                return reservation.ToList();
            }   
        }

        // GET api/<ValuesController>/email 

        public IEnumerable<Reservation> Get(string email)
        {
            using (var db = new LingToSqlDataContext())
            {
                var reservation = (
                     from details in db.Reservation
                     where details.Email == email
                     select details);

                return reservation.ToList();

            }
        }


        // POST api/values
        public void Post([FromBody] Reservation newReservation)
        {
            using (var db = new LingToSqlDataContext())
            {
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
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/email&id
        public void Delete(string email, int id)
        {
            using (var db = new LingToSqlDataContext())
            {
                var deleteOrderDetails =
                from details in db.Reservation
                where details.Email == email
                where details.Id == id
                select details;

                foreach (var detail in deleteOrderDetails)
                {
                    db.Reservation.DeleteOnSubmit(detail);
                }

                try
                {
                    db.SubmitChanges();
                }
                catch (Exception t)
                {
                    Console.WriteLine(t);
                }
            }
        }
    }
}
