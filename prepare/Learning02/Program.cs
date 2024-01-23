using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        //ASSIGNMENT
        Job job1 = new Job();
            job1._jobTitle = "Software Engineer";
            job1._company = "Microsoft";
            job1._startYear = 2019;
            job1._endYear = 2022;
            job1.Display();

        Job job2 = new Job();
            job2._jobTitle = "Manager";
            job2._company = "Apple";
            job2._startYear = 2022;
            job2._endYear = 2023;
            job2.Display();

        Resume myResume = new Resume();
            myResume._name = "Allison Rose";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

        // System.Console.WriteLine(myResume._jobs[0]._jobTitle);

//         var cars = new List<Car>();

//         var car = new Car();
//             car.make = "Honda";
//             car.model = "Civic";
//             car.gallons = 10;
//             car.milesPerGallon = 30;

//             var owner  = new Owner();
//             owner.name = "Bob";
//             owner.phone = "333-3333";
//             car.owner = owner;

//         cars.Add(car);
        
//         car = new Car();
//             car.make = "Ford";
//             car.model = "F-150";
//             car.gallons = 30;
//             car.milesPerGallon = 5;

//             owner  = new Owner();
//             owner.name = "Sue";
//             owner.phone = "222-2222";
//             car.owner = owner;

//         cars.Add(car);

//         foreach (Car c in cars){
//             // System.Console.WriteLine($"{c.make} {c.model}: Range = {c.gallons * c.milesPerGallon}");
//             c.Display();
//             int range = c.TotalRange();
//         }
    }
// }

// public class Owner {
//     public string name;
//     public string phone;
// }

// public class Car {
//     public int milesPerGallon;
//     public int gallons;
//     public string make;
//     public string model;
//     public Owner owner;

//     public Car(string make, string model, int gallons, int milesPerGallon, Owner owner) {
//         this.make = make;
//         this.model = model;
//         this.gallons = gallons;
//         this.milesPerGallon = milesPerGallon;
//         this.owner = owner;
//     }

//     public int TotalRange() {
//         return gallons * milesPerGallon;
//     }

//     public void Display() {
//         System.Console.WriteLine($"{make} {model} {owner.name}: Range = {TotalRange()}");
//     }
}

