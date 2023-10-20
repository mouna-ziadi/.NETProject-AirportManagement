// See https://aka.ms/new-console-template for more information
using AM.Core.Domain;
using AM.Core.Services;
using AM.Core.Extensions;
using AM.Data;
using AM.Core.Interfaces;

Console.WriteLine("Hello, World!");


//#region 30/01/2023

////les trois techniques 

//// Question 7 

//Plane plane = new Plane();
//plane.ManufacturedDate = new DateTime(2000,1,1);
//plane.Capacity= 200;
//plane.MyPlaneType = PlaneType.Boing; 



//// Question 8

//Plane plane2 = new Plane(PlaneType.Boing, 100, new DateTime(2001, 04, 02)) ;

//// Question 9

//Plane plane3 = new Plane() {Capacity = 200 , PlaneId = 2 };






//#endregion

//#region 6/02/2023
////TP1.Q12.b
//Passenger passenger = new Passenger();
//Passenger traveller = new Traveller();
//Passenger staff = new Staff();

////Console.WriteLine(passenger.GetPassengerType());
////Console.WriteLine(traveller.GetPassengerType());
////Console.WriteLine(staff.GetPassengerType());

//// TP1.Q13.c
//passenger.BirthDate = new DateTime(2020, 6, 2);
/////passenger.GetAge(passenger);
//Console.WriteLine(passenger.Age);
//int age = 0;
//passenger.GetAge(new DateTime(2020, 6, 2), ref age);
//Console.WriteLine(age);
//#endregion

////TP2 Q13 c
////IFlightService flightService = new FlightService();
////IFlightService.GetScore scoreByNbrFlight = delegate (Passenger p)
////{
////    return p.Flights.Count();
////};

////IFlightService.GetScore scoreByNbrFlightTunis = delegate (Passenger p)
////{
////    return p.Flights
////    .Where(f=>f.Destination=="Tunis"|| f.Departure=="Tunis")
////    .Count();
////};

////flightService.GetSeniorPassenger(scoreByNbrFlight);
////flightService.GetSeniorPassenger(scoreByNbrFlightTunis);


//////TP2 Q14
////Flight flight = new Flight();


////TP3 Q8
//AMContext context = new AMContext();

//Flight flight2 = new Flight()
//{
//    Comment = "comment",
//    Departure = "Tunis",
//    Destination = "Paris",
//    EffectiveArrival = new DateTime(2023, 02, 27, 18, 18, 25),
//    EstimatedDuration = 60,
//    FlightDate = new DateTime(2023, 02, 27, 16, 18, 25),
//     FlightId = 1


//};

//context.Add(flight2);
//context.SaveChanges();


//TP5 Q9
//Flight f5 = new Flight()
//{
//    Comment = "comment",
//    Departure = "Tunis",
//    Destination = "Paris",
//    EffectiveArrival = new DateTime(2023, 02, 27, 18, 18, 25),
//    EstimatedDuration = 60,
//    FlightDate = new DateTime(2023, 02, 27, 16, 18, 25),
//};
//Passenger p5 = new Passenger()
//{
//    BirthDate= new DateTime(1998,07,18),
//    MyFullName = new FullName()
//    {
//        FirstName = "Foulen",
//        LastName ="Ben Foulen"
//    },
//    EmailAddress = "foulen@gmail.com",
//    TelNumber = "23654789",
//    PassportNumber="1234567"
//};


//Reservation r = new Reservation()
//{
//    MyFlight= f5,
//    MyPassenger= p5,
//    Price = 1000,
//    Seat= "236",
//    Vip = true
//};
//AMContext cpx = new AMContext();
//cpx.Add(p5);
//cpx.Add(f5);
//cpx.Add(r);
//cpx.SaveChanges();

//TP5 Q10
//Plane plane1 = new Plane()
//{
//    ManufacturedDate = new DateTime(2000, 1, 1),
//    Capacity = 200,
//    MyPlaneType = PlaneType.Boing

//};
//Flight f6 = new Flight()
//{
//    Comment = "comment",
//    Departure = "Tunis",
//    Destination = "Paris",
//    EffectiveArrival = new DateTime(2023, 02, 27, 18, 18, 25),
//    EstimatedDuration = 60,
//    FlightDate = new DateTime(2023, 02, 27, 16, 18, 25),
//    MyPlane = plane1
//};
//cpx.Add(plane1);
//cpx.Add(f6);
//cpx.SaveChanges();
//Console.WriteLine(f6);
//Console.WriteLine(f6.MyPlane);


////TP5 Q11
//Flight f = (Flight)cpx.Find(typeof(Flight), 3);
//Console.WriteLine(f);
//Console.WriteLine(f.MyPlane);

//TP6 Q6
Flight f6 = new Flight()
{
    Comment = "comment",
    Departure = "Tunis",
    Destination = "Italy",
    EffectiveArrival = new DateTime(2023, 02, 27, 18, 18, 25),
    EstimatedDuration = 60,
    FlightDate = new DateTime(2023, 02, 27, 16, 18, 25)
};
Plane plane1 = new Plane()
{
    ManufacturedDate = new DateTime(2000, 1, 1),
    Capacity = 150,
    MyPlaneType = PlaneType.Boing

};

//AMContext cpx = new AMContext();

//IRepository<Plane> planeRepo = new Repository<Plane>(cpx);
////IPlaneService planeService = new PlaneService(planeRepo);

//IRepository<Flight> flightRepo = new Repository<Flight>(cpx);
///IFlightService flightService = new FlightService(flightRepo);

//flightService.Add(f6);
//planeService.Add(plane1);




