using System;

namespace The_Crypto_Calculator
{
            class Engine
        {
            static void Main(string[] args)
            {
                Console.Write("Enter Average Buy-In Price: ");
                double buyInPrice;
                bool check = Double.TryParse(Console.ReadLine(), out buyInPrice);
                Console.Write("Enter New Crypto Price: ");
                double newCryptoPrice;
                check = Double.TryParse(Console.ReadLine(), out newCryptoPrice);
                Console.Write("Enter Total Money Invested: ");
                double totalMoneyInvested;
                check = Double.TryParse(Console.ReadLine(), out totalMoneyInvested);
                Console.Write("Enter Total Coins Mined (If Any): ");
                double coinsMined;
                check = Double.TryParse(Console.ReadLine(), out coinsMined);
                Console.Write("Enter Tax Rate (Ex. 10 or 10.00): ");
                double taxRate;
                check = Double.TryParse(Console.ReadLine(), out taxRate);
                double finalTaxRate = taxRate / 100;
                double totalGrowthPercentage = (newCryptoPrice / buyInPrice);
                double cryptoOwned = (totalMoneyInvested / buyInPrice) + coinsMined;
                double beforeTaxFinal = (totalGrowthPercentage * totalMoneyInvested) + coinsMined;
                double afterTaxFinal = beforeTaxFinal * (1 - finalTaxRate);
                //Console.WriteLine($"Total Growth % is {totalGrowthPercentage}%");
                Console.WriteLine($"Total Crypto Owned: {cryptoOwned}");
                Console.WriteLine($"Before Tax Value: ${beforeTaxFinal}");
                Console.WriteLine($"Final Value: ${afterTaxFinal}");

            }
        }
    }
