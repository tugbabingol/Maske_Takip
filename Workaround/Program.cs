using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround
{
    class Program
    {//sdfs
        static void Main(string[] args)
        {

            Person person1 = new Person();
            person1.FirstName = "Tuğba";
            person1.LastName = "Bingöl";
            person1.DateOfBirthYear = 2000;
            person1.NationalIdentity = 123;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);


            Console.ReadLine();

        }

        
    }

}