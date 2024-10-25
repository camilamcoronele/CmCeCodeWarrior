using System;

class PersonalInfo
{
    public static void PrintInfo()
    {
        string[] names = new string[4] { "Lucinda Potter", "John Smith", "Chris Johnson", "Robert Hall" };
        string[] birthdates = new string[4] { "06/24/1992", "08/15/1978", "12/01/1987", "02/27/1949" };
        string[] workPhones = new string[4] { "000-000-0101", "000-111-0101", "000-222-0101", "000-444-0101" };
        string[] cellPhones = new string[4] { "000-000-0189", "000-111-0189", "000-222-0189", "000-444-0189" };

        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]); 
            Console.WriteLine(birthdates[i]); 
            Console.WriteLine("Work: " + workPhones[i]);
            Console.WriteLine("Cell: " + cellPhones[i]);
            Console.WriteLine(); 
        }
    }
}