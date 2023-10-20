using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public class Passenger
    {
        //    public int Id { get; set; }


        [DataType(DataType.Date)]
        [Display(Name = "Date of birth")]
        public DateTime BirthDate { get; set; }


      
        [MinLength (3, ErrorMessage="Min Lenght 3")]
        [MaxLength(25, ErrorMessage = "Max Lenght 25")]
        //[StringLength(10)] controlle cote user / StringLength<MaxLenght
        // public string FirstName { get; set; }

        public FullName MyFullName { get; set; }

        // public string LastName { get; set; }
        [EmailAddress (ErrorMessage = "EmailAddress")]
        //[DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }


       
        
        [DataType(DataType.PhoneNumber, ErrorMessage = "invalid PhoneNumber")]
        public string TelNumber { get; set; }

        [Key]
        [MaxLength(7, ErrorMessage = "Max Lenght 7")]
        public string PassportNumber { get; set; }

        //TP5 Q6
        //public IList<Flight> Flights { get; set; }
        public virtual IList<Reservation> Reservations { get; set; }

        //TP1.Q14
        int age;
        public int Age {
            get {
                age = (DateTime.Now.Year - BirthDate.Year);
                if (BirthDate.AddYears(age) < DateTime.Now)
                {
                    age--;
                }
                return age;
            } 
        }


        public override string ToString()
        {
            return "Birth Date : " + BirthDate + ";FirstName : " + MyFullName.FirstName + ";Last Name : " + MyFullName.LastName +
                ";Email Address :" + EmailAddress + ";Tel Number :" + TelNumber + ";Passport Number :" + PassportNumber
                ;
        }
        // TP1.Question 11.a 
        // 
        // public bool CheckProfile(string firstname, string lastname)
        //{
        //    //if (this.FirstName== firstname && this.LastName == lastname) {
        //    //    return true;
        //    //}
        //    //return false;
        //    return FirstName == firstname && LastName == lastname;
        //}
        // TP1.Question 11.b 
        //public bool CheckProfile(string firstname, string lastname,string email)
        //{
        //    return FirstName == firstname && LastName == lastname && EmailAddress == email;
        //}

        // TP1.Question 11.c 
        public bool CheckProfile(string firstname, string lastname, string email=null)
        {
            //if (email == null)
            //return FirstName == firstname && LastName == lastname;
            //else
            //return FirstName == firstname && LastName == lastname && EmailAddress == email;

            return MyFullName.FirstName == firstname && MyFullName.LastName == lastname 
                && ( EmailAddress == email || email == null) ;

        }

         public  virtual string GetPassengerType()
        {
            return "I am Passenger ";
        }


        public void GetAge(DateTime birthDate, ref int  calculatedAge)
        {
           
           calculatedAge  =  (DateTime.Now.Year - birthDate.Year);
            if (birthDate.AddYears(calculatedAge) < DateTime.Now)
            {
                calculatedAge--;
            }
         // 2eme méthode
         //if (DateTime.Now.Month<birthDate.Month)
         //   {
         //       calculatedAge--;
         //   }
         //else if (DateTime.Now.Month == birthDate.Month) {
         //       if (DateTime.Now.Day < birthDate.Day)
         //       {
         //           calculatedAge--;
         //       }
         //   }
        }

      /* public  void GetAge(Passenger aPassenger)
        {
            aPassenger.Age = (DateTime.Now.Year - aPassenger.BirthDate.Year);
            if (aPassenger.BirthDate.AddYears(aPassenger.Age) < DateTime.Now)
            {
                aPassenger.Age--;
            }
        }*/

    }
}
