using System;

class Program
{
    public static float CalcAverage(int[] marks)
    {
        return (marks[0] + marks[1] + marks[2]) / 3;
    }

    public static string[] GrabLocationInfo(string[] locationMessages)
    {
        string[] results = new string[locationMessages.Length];
        for (int i = 0; i < locationMessages.Length; i++)
        {
            Console.WriteLine(locationMessages[i]);
            results[i] = Console.ReadLine();
        }
        return results;
    }

    public static float GrabUserMarks(string[] markMessages)
    {
        int[] marks = new int[markMessages.Length];
        for (int i = 0; i < markMessages.Length; i++)
        {
            Console.WriteLine(markMessages[i]);
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
        const string MSG_ASKZIPCODE = "Introduce tu código postal";
        const string MSG_ASKCITYNAME = "Introduce el nombre de tu ciudad";
        const string MSG_DISPLAYAVG = "El promig de les notes es: {0}";
        const string MSG_DISPLAYZIP = "El codigo postal es: {0}";
        const string MSG_DISPLAYCITY = "La ciudad es: {0}";
        const string MSG_PASSED = "Aprovat";
        const string MSG_FAILED = "Suspès";

        string[] markMessages = { MSG_FIRSTQUALIFICATIONIN, MSG_SECONDQUALIFICATIONIN, MSG_THIRDQUALIFICATIONIN };
        string[] locationMessages = { MSG_ASKZIPCODE, MSG_ASKCITYNAME };

        // Variables

        float averageResult;
        string[] locationData;

        // Main code

        averageResult = GrabUserMarks(markMessages);
        locationData = GrabLocationInfo(locationMessages);

        Console.WriteLine(MSG_DISPLAYAVG, averageResult);

        Console.WriteLine(MSG_DISPLAYZIP, locationData[0]);
        Console.WriteLine(MSG_DISPLAYCITY, locationData[1]);

        Console.WriteLine(averageResult > 6 ? MSG_PASSED : MSG_FAILED);
    }
}
