using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain 
{
    public class Flight
    {
        public  string Destination { get; set; }

        public  string Departure { get; set; }

        //[Column(TypeName ="date")]
        public DateTime EffectiveArrival { get; set; }

        public int EstimatedDuration { get; set; }

        public DateTime FlightDate { get; set; }

        public int FlightId { get; set; }

        public string Comment { get; set; }

        //[ForeignKey("PlaneId")]
        public virtual Plane ? MyPlane { get; set; }

        [ForeignKey("MyPlane")]
        
        public int ? PlaneId { get; set; }

        //tp5 Q6
        // public IList<Passenger> Passengers { get; set; }
        public virtual IList<Reservation> Reservations { get; set; }

        public override string ToString()
        {
            return "Departure : " + Departure + ";Destination :" + Destination + ";EffectiveArrival : " + EffectiveArrival
                + ";EstimatedDuration : " + EstimatedDuration + ";FlightDate : " + FlightDate + ";Flight ID : " + FlightId ;
        }
    
    
    
    
    }
}
