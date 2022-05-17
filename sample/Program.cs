using System.ComponentModel;
using static System.Net.Mime.MediaTypeNames;

public class Program
{
    public static PatternType GetPatternType()
    {
        Console.WriteLine("enter the type of pattern you want");
        var patterns = Enum.GetValues(typeof(PatternType));
        foreach (var pattern in patterns)
        {
            Console.WriteLine($"{(int)pattern} : {pattern}");
        }
        PatternType type = patterntype();
        return type;
    }
    public static void Main(string[]? args)
    {
        PatternType type = GetPatternType();

        int number = readno();
        string ptrn = "*";

        ptrn = patternletter();

        switch (type)
        {
            case PatternType.LeftHandedTriangle:
                LeftHanded(ptrn, number);
                break;
            case PatternType.RightHandedTriangle:
                RightHanded(ptrn, number);
                break;
            case PatternType.IsocelusTriangle:
                Isoseless(ptrn, number);
                break;
            case PatternType.Rectangle:
                Rectangle(ptrn, number);
                break;
        }
        IsQuit();

    }

    public static void IsQuit()
    {
        Console.WriteLine("Do you want to quit? y/n");
        var isquit = Console.ReadLine();
        switch (isquit)
        {
            case "n":
                Main(null);
                break;
            case "y":
                Environment.Exit(-1);
                break;
            default:
                Console.WriteLine("please enter y/n");
                IsQuit();
                break;



        }

    }
    public static void RightHanded(string ptrn, int number)
    {

        for (int i = 0; i <= number; i++)
        {
            for (int j = number; j > i; j--)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < i; j++)
            {
                if (ptrn == "*")
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(i);
                }


            }
            Console.WriteLine();


        }
    }
    public static void LeftHanded(string ptrn, int number)
    {
        for (int i = 0; i <= number; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (ptrn == "*")
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(i);
                }
            }
            Console.WriteLine("");

        }
    }
    public static void Isoseless(string ptrn, int number)
    {
        for (int i = 1; i <= number; i++)
        {
            for (int k = i; k < number; k++)
            {
                Console.Write(" ");

            }
            for (int j = 1; j < 2 * i; j++)
            {
                if (ptrn == "*")
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(i);
                }
            }

            Console.WriteLine();
        }
    }
    public static void Rectangle(string ptrn, int number)
    {
        for(int i = 1; i <= number; i++)
        {
            for (int j=1; j <= number; j++)
            {
                if (ptrn == "*")
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(i*j+" ");
                }
            }
            Console.WriteLine("");
        }
    }
    public static PatternType patterntype()
    {
        PatternType type = 0;
        bool exist = false;
        while (!exist)
        {
            Console.WriteLine("please enter the sl.no 1,2,3 or 4");

            var input = Console.ReadLine();
            Int32.TryParse(input, out int inputToNumber);
            exist = Enum.IsDefined(typeof(PatternType), Convert.ToInt32(inputToNumber));
            type = (PatternType)Enum.Parse(typeof(PatternType), inputToNumber.ToString());
        }
        return type;
    }
    public static string patternletter()
    {
        string ptrn;
        do
        {
            Console.WriteLine("star pattern(*) or number pattern(1)");
            ptrn = Convert.ToString(Console.ReadLine());
            //  Console.WriteLine(ptrn);
        }
        while (IsAllowedChar(ptrn));

        return ptrn;
    }
    public static int readno()
    {
        int no;
        Console.WriteLine("Enter a number");
        try
        {
            no = Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception)
        {

            Console.WriteLine("please enter a number");
            no = readno();
        }
        return no;
    }

    public static bool IsAllowedChar(string ptrn)
    {
        return ptrn != "*" && ptrn != "1";
    }
}

public enum PatternType
{
    LeftHandedTriangle = 1,
    RightHandedTriangle = 2,
    IsocelusTriangle = 3,
    Rectangle = 4
}
