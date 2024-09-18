using System;

class Program
{
    static float CalcAverage(int[] marks)
    {
        return (marks[0] + marks[1] + marks[2]) / 3;
    }

    static float GrabUserMarks(string[] messages)
    {
        int[] marks = new int[messages.Length];
        for (int i = 0; i < messages.Length; i++)
        {
            Console.WriteLine(messages[i]);
            marks[i] = Convert.ToInt32(Console.ReadLine());
        }
        return CalcAverage(marks);
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

        string[] messages = {MSG_FIRSTQUALIFICATIONIN, MSG_SECONDQUALIFICATIONIN, MSG_THIRDQUALIFICATIONIN};

        // Variables

        float averageResult;

        // Main code

        averageResult = GrabUserMarks(messages);

        Console.WriteLine(MSG_DISPLAYAVG, averageResult);

        Console.WriteLine(averageResult > 6 ? MSG_PASSED : MSG_FAILED);
    }
}
