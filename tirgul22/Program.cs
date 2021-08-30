using System;

namespace tirgul22
{

    class Program
    {
        static void Main(string[] args)
        {
            person[] person = new person[50];
            for (int i = 0; i < person.Length; i++)
            {
                person[i] = new person();
                person[i].RandomString();
                person[i].RandomID();
                person[i].RandomIfPast();
                person[i].events();
                person[i].print();
            }
            AddEvent(person);
            Console.WriteLine("-------------------------------------------");

            Police[] police = new Police[3];
            police[0] = new Police("203425881", "sharon", "bitton", 2332);
            police[1] = new Police("314471982", "lior", "avrham", 8912);
            police[2] = new Police("214587911", "matan", "danoh", 1188);
            for (int i = 0; i < police.Length; i++)
                police[i].print();
            Console.WriteLine("-------------------------------------------");
            //for (int i = 0; i < police.Length; i++)
            //{
            //    police[i].print();
            //}
            for (int i = 0; i < person.Length; i++)
                person[i].printevent();
            Console.WriteLine("------------------------------------------");
            while (true)
            {
                Console.WriteLine("tap 0 To Exit");
                Console.Write("ID: ");
                string user = Console.ReadLine();
                if (user == 0 + "")
                    break;
                if (Police.LoginID(police, user) == false)
                {
                    Console.WriteLine("Erorr, officer not detected");
                    continue;
                }
                Console.Write("Password: ");
                int intuser = int.Parse(Console.ReadLine());
                if (Police.LoginPassword(police, intuser) == false)
                {
                    Console.WriteLine("Erorr, TRY Again");
                    continue;
                }
                Console.WriteLine("Hello Officer");
                while (true)
                {
                    Console.Write("person ID: ");
                    user = Console.ReadLine();
                    if (user == 0 + "")
                        break;
                    if (CheckID(person, user) == false)
                    {
                        Console.WriteLine("Erorr, ID not detected, Try again");
                        continue;
                    }
                    ShowPerson(person, user);
                    if (CheckPast(person, user))
                    { 
                        Console.WriteLine("do you want to see the criminal event? ");
                        string choice = Console.ReadLine();
                        if (choice != "yes")
                            continue;

                        Console.WriteLine(ShowEvent(person, user)); 
                    } 

                }
            }



        }
        public static bool CheckID(person[] arr, string user)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].ID == user)
                    return true;
            }
            return false;
        }


        static void ShowPerson(person[] arr, string user)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i].ID == user)
                    arr[i].print();
        }
        public static bool CheckPast(person[] arr, string user)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].ID == user && arr[i].IsHasPast==true)
                    return true;
            }
            return false;
        }

        static string ShowEvent(person[] arr, string user)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].ID == user)
                    return arr[i].Event;
            }
            return "has no Event";
        }

        static string AddEvent(person[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i].IsHasPast)
                 return arr[i].Event +=" ,"+ arr[i].events();
            return "";
        }
    }
}
