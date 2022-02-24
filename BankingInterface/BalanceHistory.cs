using System;
using System.Collections.Generic;
using System.Text;

namespace BankingInterface
{
    class BalanceHistory : User
    {
        private static double currentBalance;

        public static double getCurrentBalance()
        {
            return currentBalance;
        }
        public static void depositCheck(double amount)
        {
            currentBalance += amount;
        }
    }
}
