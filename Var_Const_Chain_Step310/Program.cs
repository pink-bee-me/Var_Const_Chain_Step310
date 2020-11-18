using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Var_Const_Chain_Step310
{
    class Program
    {
        static void Main(string[] args)
        { 
            // establishing system for automatically scheduling date of future appointments ( for 6wks or 6mos out)  
            // the actual time of day the appointment will be scheduled is entered by user

            DateTime currentDateTime = DateTime.Now;

            DateTime nextVisit_6mo = currentDateTime.AddMonths(6);
            string appointment_6mo = nextVisit_6mo.ToString("ddd,dd MMM yyy");

            DateTime nextVisit_6wk = currentDateTime.AddDays(42);
            string appointment_6wk = nextVisit_6wk.ToString("ddd,dd MMM yyy");


            // creating instances of pet clients and adding them to List
     

            Pet pet_1 = new Pet("dog_0001");
            Pet pet_2 = new Pet("cat_0015");
            Pet pet_3 = new Pet("snake_0021");
            Pet pet_4 = new Pet("Haisler", "Suzie-Q");
            Pet pet_5 = new Pet("Peterson", "Li'l Bit");
            Pet pet_6 = new Pet("Valliquette", "LuLu");
            Pet pet_7 = new Pet("Valliquette", "Moo");

            pet_1.PetFamilyName = "Ledington";
            pet_1.OwnerName = "Jeremy";
            pet_1.PetName = "Boo";
            pet_1.PetType = "Dog";
            pet_1.PetGender = "Female";
            pet_1.PetBreed = "Chihuahua";
            pet_1.PetAge = "6 weeks";
            pet_1.NextAppointment = appointment_6wk;
            pet_1.ApptTime = "10:00am";

            pet_2.PetFamilyName = "Keeney";
            pet_2.OwnerName = "Sandra";
            pet_2.PetName = "Ming";
            pet_2.PetType = "Cat";
            pet_2.PetGender = "Male";
            pet_2.PetBreed = "Burmese";
            pet_2.PetAge = "9";
            pet_2.NextAppointment = appointment_6mo;
            pet_1.ApptTime = "5:00pm";

            pet_3.PetFamilyName = "Elam";
            pet_3.OwnerName = "Jordan";
            pet_3.PetName = "Vinnie";
            pet_3.PetType = "Snake";
            pet_3.PetGender = "Male";
            pet_3.PetBreed = "Boa";
            pet_3.PetAge = "6 weeks";
            pet_3.NextAppointment = appointment_6wk;
            pet_1.ApptTime = "3:30pm";

            pet_4.OwnerName = "Joe";
            pet_4.PetType = "Alligator";
            pet_4.PetGender = "Female";
            pet_4.PetBreed = "N/A";
            pet_4.PetAge = "3" ;
            pet_4.NextAppointment = appointment_6mo;
            pet_4.ApptTime = "12:00pm";

            pet_5.PetFamilyName = "Peterson";
            pet_5.OwnerName = "LaurieSue";
            pet_5.PetName = "Li'l Bit";
            pet_5.PetType = "Dog";
            pet_5.PetGender = "Male";
            pet_5.PetBreed = "Staffordshire";
            pet_5.PetAge = "6";
            pet_5.NextAppointment = appointment_6mo;
            pet_5.ApptTime = "9:00am";

            pet_6.PetFamilyName = "Valliquette";
            pet_6.OwnerName = "Kristi";
            pet_6.PetName = "Lulu";
            pet_6.PetType = "Dog";
            pet_6.PetGender = "Female";
            pet_6.PetBreed = "Mastiff";
            pet_6.PetAge = "4";
            pet_6.NextAppointment = appointment_6wk;
            pet_6.ApptTime = "2:30pm";

            pet_7.PetFamilyName = "Valliquette";
            pet_7.OwnerName = "Kristi";
            pet_7.PetName = "Moo";
            pet_7.PetType = "Dog";
            pet_7.PetGender = "Male";
            pet_7.PetBreed = "Mastiff/BirdDog";
            pet_7.PetAge = "6 mo";
            pet_7.NextAppointment = appointment_6mo;
            pet_7.ApptTime = "4:45pm";

            List<Pet> Pets = new List<Pet>() { pet_1, pet_2, pet_3, pet_4, pet_5, pet_6, pet_7 };
            

            Console.WriteLine("The Pet Clinic Appointment and Record Keeper");

            Console.WriteLine("\n\nTo Pull Up The Schedule You Need to Log In: \n\nEnter Your Initials:");
            var logInInitials = Console.ReadLine();
            Console.WriteLine("Enter Your Date of Birth (mm/dd/yyyy): ");
            var logInDOB = Console.ReadLine();

            using (StreamWriter file = new StreamWriter(@"C:\Users\LaurieSue\Logs\log.txt", true))
            {
                file.WriteLine("{0}  {1}  {2}",currentDateTime, logInInitials, logInDOB);
            }

            const string schedule = "Date                       Time                   Name               Type              Owner               ";
            const string line =     "____________________________________________________________________________________________________________";


            Console.WriteLine("\n\n " + schedule);
            Console.WriteLine(line);
         
            foreach (Pet pet in Pets)
            { 
                for(int i = 0; i < Pets.Count; i++)
                    {

                    Console.WriteLine("{0}           {1}              {2}             {3} {4}           "
                        , Pets[i].NextAppointment, Pets[i].ApptTime, Pets[i].PetName, Pets[i].PetType, Pets[i].OwnerName, Pets[i].PetFamilyName);
                }
                
            }
            Console.Read();

        }
    }
}
