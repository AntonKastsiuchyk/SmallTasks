using AirportSimulation.AirportServices;
using AirportSimulation.Entities;
using AirportSimulation.Support;
using System;

namespace AirportSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Welcome.WelcomeToAirport();
            string name = Console.ReadLine();
            string firstNames, lastName;
            SplitFullName.SplitName(name, out firstNames, out lastName);

            Console.WriteLine($"{firstNames}, welcome to check-in desk. Please answer for a few questions.");

            Console.WriteLine($"First of all, please input your date of birthday (yyyy,mm,d): ");
            Passport passport = new Passport();
            passport.DateOfBirth = CheckType.GetDateFromConsole();
            CheckDB.CheckDateOfBirth(passport);

            Console.WriteLine($"Are you have a visa, {firstNames}? (yes or no)");
            Visa visa = new Visa();
            visa.Status = CheckVisa.CheckOfVisa();

            Console.WriteLine($"{firstNames}, please input your passport number: ");
            passport.Number = Console.ReadLine();

            Console.WriteLine($"{firstNames}, now please input passport issued (yyyy,mm,d): ");
            passport.Issued = CheckType.GetDateFromConsole();

            Console.WriteLine($"{firstNames}, now please input passport expired (yyyy,mm,d): ");
            passport.Expired = CheckType.GetDateFromConsole();

            CheckPassport.CheckDatesOfPassport(passport);

            Console.WriteLine($"Are you have a online registration, {firstNames}? (yes or no)");
            Ticket ticket = new Ticket();
            ticket.NumberOfTicket = CheckTicket.CheckOnlineRegistration(ticket);

            Console.WriteLine($"\nDo you have any luggage, {firstNames}? (yes or no)");

            Bag bag = new Bag();
            CheckBag.CheckWeightOfBag(bag);

            Console.WriteLine($"{firstNames}, allright! Please go to security check. (any key)");
            Console.ReadKey();

            Console.WriteLine($"{firstNames}, welcome to security check. Open your case for examination, please." +
                $"\nDo you have anything forbidden in your suitcase: drugs, guns, explosive materials? (yes or no)");
            SecurityEmployee security = new SecurityEmployee();
            security.ForbiddenItem = SecurityCheck.CheckForbiddenItem(security);

            Console.WriteLine($"{firstNames}, welcome to passport control. May I see your passport and ticket, please? (yes or no)");
            Passanger passanger = new Passanger(name, passport, ticket, visa, bag);
            PassportControlEmployee passportControlEmployee = new PassportControlEmployee();
            passportControlEmployee.Passanger = PassportControl.CheckPassanger(passanger);
        }
    }
}
