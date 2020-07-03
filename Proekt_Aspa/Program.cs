using Microsoft.VisualBasic;
using Proekt_Aspa.Models;
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Proekt_Aspa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to guest house Aspa, village of Asparuhovo!");
            Console.WriteLine("Please select one of the listed options!");

            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();

            }

        }

        public static bool MainMenu()
        {

            Console.WriteLine("1) Information for the house");
            Console.WriteLine("2) Rooms Price");
            Console.WriteLine("3) Contacts");
            Console.WriteLine("4) Registration");
            Console.WriteLine("5) Show all reservations");
            Console.WriteLine("6) Exit");
            Console.Write("Please select an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Information();
                    return true;
                case "2":
                    InformationPriceForRoom();
                    return true;
                case "3":
                    Contact();
                    return true;
                case "4":
                    Registration();
                    return true;
                case "5":
                    AllReservations();
                    return true;
                case "6":
                    Exit();
                    return false;
                default:
                    return true;
            }

        }

        private static void AllReservations()
        {


            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.EnableRaisingEvents = false;
            proc.StartInfo.EnvironmentVariables.Add("file", "D:\\NetIt\\Proekt_Aspa\\Text_Files\\Clients.txt");
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.FileName = "notepad";

            proc.StartInfo.Arguments = "D:\\NetIt\\Proekt_Aspa\\Text_Files\\Clients.txt";
            proc.Start();
            proc.WaitForExit();

            Console.WriteLine(proc.ExitCode);
            //string[] clients = File.ReadAllLines(@"D:\NetIt\Proekt_Aspa\Text_Files\Clients.txt");

            //foreach (var client in clients)
            //{
            //    string[] clientsElement = client.Split("=", StringSplitOptions.RemoveEmptyEntries);

            //    string firstCol = clientsElement[0];
            //    string secondCol = clientsElement[1];



            //    Console.WriteLine($"{firstCol}      {secondCol} ");
            //    Console.WriteLine();
            //}
        }

        private static void Contact()
        {
            Contacts contact = new Contacts();
            Console.WriteLine($"Contact phone: {contact.TelNumber}");
            Console.WriteLine($"Contact email adress: {contact.Email}");
            Console.WriteLine();
        }

        private static void Exit()
        {
            Environment.Exit(0);
        }

        private static void Information()
        {
            try
            {
                using (StreamReader text = new StreamReader(@"D:\NetIt\Proekt_Aspa\Text_Files\Info.txt"))
                {

                    String line = text.ReadToEnd();
                    Console.WriteLine(line);

                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

        }

        private static void InformationPriceForRoom()
        {
            Rooms room1 = new Rooms();
            Rooms ap = new Rooms();

            Console.WriteLine($"We offer {room1.Type} at a price {room1.Price}lv.");
            Console.WriteLine($"We offer {ap.Type} at a price {ap.Price}lv.");
            Console.WriteLine();
        }

        public static void Registration()
        {
            Clients client = new Clients();
            Rooms room = new Rooms();


            Console.WriteLine("Registration Form");


            Console.Write("Pleace enter the first name:");
            client.FirstName = Console.ReadLine();
            Console.Write("Pleace enter the family name:");
            client.LastName = Console.ReadLine();
            Console.Write("Number of guests:");
            client.BroiGosti = int.Parse(Console.ReadLine());
            Console.Write("Pleace enter the phone number:");
            client.PhoneNumber = long.Parse(Console.ReadLine());
            Console.Write("Pleace enter a date and time of arrival:");
            client.DateCreated = DateTime.Parse(Console.ReadLine());
            Console.Write("Pleace enter a date and time of leaving:");
            client.DataClose = DateTime.Parse(Console.ReadLine());
            Console.Write("Pleace enter a date and time of leaving:");
            room.Type = $"Please select a room to stay: {room.Type}";
            Console.WriteLine();

            

            string fileName = @"D:\NetIt\Proekt_Aspa\Text_Files\Clients.txt";


            using (StreamWriter sw = File.AppendText(fileName))
            {


                sw.WriteLine($"ID = {client.ID}");
                sw.WriteLine($"FirstName = {client.FirstName}");
                sw.WriteLine($"LastName = {client.LastName}");
                sw.WriteLine($"BroiGosti = { client.BroiGosti}");
                sw.WriteLine($"PhoneNumber = {client.PhoneNumber}");
                sw.WriteLine($"DateReservation = {client.DateCreated}");
            }


            //StringBuilder sb = new StringBuilder();
            //sb.AppendLine($"ID = {client.ID}");
            //sb.AppendLine($"FirstName = {client.FirstName}");
            //sb.AppendLine($"LastName = {client.LastName}");
            //sb.AppendLine($"BroiGosti = {client.BroiGosti}");
            //sb.AppendLine($"PhoneNumber = {client.PhoneNumber}");
            //sb.AppendLine($"DateReservation = {client.DateCreated}");

            //writer.Write(sb.ToString());
        }
    }


}


