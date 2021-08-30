using System;
using System.Collections.Generic;
using System.Text;

namespace tirgul22
{
    
    class Police
    {
        public string ID;
        public String Firsname;
        public string Lastname;
        public int Password;

        public Police()
        {

        }
        public Police(string id, string firsname, string lastname, int password)
        {
            ID = id;
            Firsname = firsname;
            Lastname = lastname;
            Password = password;
        }

        public void print()
        {
            Console.WriteLine("full name: {0} {1}, ID:{2}, password: {3}", Firsname, Lastname, ID, Password);
        }
        
        public static bool LoginID(Police[] arr, string user)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].ID == user)
                    return true;
            }
            return false;
        }
        public static bool LoginPassword(Police[] arr,int user)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Password == user)
                    return true;
            }
            return false;
        }


    }
}
