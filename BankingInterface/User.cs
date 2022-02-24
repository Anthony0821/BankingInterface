using System;
using System.Collections.Generic;
using System.Text;

namespace BankingInterface
{
    class User
    {
        static string firstName, lastName;
        static int age = 25;

        public static string requestUserName() 
        {
            firstName = "Anthony";
            lastName = "Leach";
            return (firstName + " " + lastName);
        }
        //private static int getCurrentBalance(int ssn, int dob)
        //{

           // return BankingInterface.BalanceHistory.getCurrentBalance;
        //}
    }
}
