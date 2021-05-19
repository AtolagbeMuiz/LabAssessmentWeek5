using System;

namespace LabAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            // BankA bankA = new BankA();
            // bankA.getBalance();

            // BankB bankB = new BankB();
            // bankB.getBalance();

            // BankC bankC = new BankC();
            // bankC.getBalance();

            
            int[] studentAMarks = {20, 30, 60};

            StudentA studentA = new StudentA(studentAMarks);
            studentA.getPercentage();
            
            int[] studentBMarks = {20, 30, 60, 90};
            StudentB studentB = new StudentB(studentBMarks);
            studentB.getPercentage();
        }
    }
}
