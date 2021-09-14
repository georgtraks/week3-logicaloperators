using System;

namespace BootleanLogicOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnus;
            //programm küsib kasutajal sisestada parool;
            //programm kontrollib, kas mõlemad, nii kasutajatunnus 
            //kui ka parool on õiged;
            //kui mõlemad, kasutajatunnus japarool on õiged
            //programm kuvab konsoolis "tere tulemast!"
            //kui kasutajatunnus võiparool on vale, siis
            //programm kuvab "sisselogimine ebaõnnestus. proovi uuesti."
            //kt :admin, pr: admin1234


            Console.WriteLine("sisestage kasutajatunnus.");
            string username = Console.ReadLine();
            Console.WriteLine("sisesta parool.");
            string userpassword = Console.ReadLine();
            if(username == "admin" && userpassword == "admin1234")
            {
                Console.WriteLine("tere tulemast");
            }
            else
            {
                Console.WriteLine("sisselogimine ebaõnnestus. prooviuuesti.");
            }

        }
    }
}
