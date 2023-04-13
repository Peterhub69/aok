using System;
class Program

{

    static void Main(string[] args)

    {

        ZwierzakDomowy zwierzak = new ZwierzakDomowy("Kot Ciat", "kot", new DateTime(2020, 1, 1));

        Console.WriteLine(zwierzak.ToString());


        try

        {

            ZwierzakDomowy zlyZwierzak = new ZwierzakDomowy("Reksio", "pies", new DateTime(2023, 1, 1));

            Console.WriteLine(zlyZwierzak.ToString());

        }

        catch (Exception e)

        {

            Console.WriteLine(e.Message);

        }

    }

}