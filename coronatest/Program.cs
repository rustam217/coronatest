using System;


namespace coronatest

{

    class Program
    {
        static void Main(string[] args)
        {
            var daysOnWeek = new string[]
            {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

            decimal[] tempStat = new decimal[daysOnWeek.Length];
            for (int i = 0; i < daysOnWeek.Length; i++)
            {

                while (true)
                {
                    Console.Write($"Enter body temperature for {daysOnWeek[i]}\n>");
                    var input = ((Console.ReadLine()));
                    if (input == " ") break;
                    else if ((decimal.Parse(input) < 41) && (decimal.Parse(input) > 30))
                    {
                        tempStat[i] = (decimal.Parse(input));
                        break;
                    }
                    else Console.WriteLine("Body temperature incorrect");
                }
            }
        }
    }
}
           