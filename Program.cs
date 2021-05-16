using System;

namespace LabAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            BankA bankA = new BankA();
            bankA.getBalance();

            BankB bankB = new BankB();
            bankB.getBalance();

            BankC bankC = new BankC();
            bankC.getBalance();
        }
    }
}
