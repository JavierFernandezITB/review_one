using System;

class Program
{
    static float CalcAverage(int[] marks)
    {
        return (marks[0] + marks[1] + marks[2]) / 3;
    }

    static void Main(string[] args)
    {
        // Messages
        
        const string MSG_FIRSTQUALIFICATIONIN = "Introdueix la primera qualificació";
        const string MSG_SECONDQUALIFICATIONIN = "Introdueix la segona qualificació";
        const string MSG_THIRDQUALIFICATIONIN = "Introdueix la tercera qualificació";
        const string MSG_DISPLAYAVG = "El promig de les notes es: {0}";
        const string MSG_PASSED = "Aprovat";
        const string MSG_FAILED = "Suspès";

        // Variables

        int[] marks = new int[3];
        float averageResult;

        // Main code

        Console.WriteLine(MSG_FIRSTQUALIFICATIONIN);
        marks[0] = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(MSG_SECONDQUALIFICATIONIN);
        marks[1] = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(MSG_THIRDQUALIFICATIONIN);
        marks[2] = Convert.ToInt32(Console.ReadLine());

        averageResult = CalcAverage(marks);

        Console.WriteLine(MSG_DISPLAYAVG, averageResult);

        Console.WriteLine(averageResult > 6 ? MSG_PASSED : MSG_FAILED);
    }
}
