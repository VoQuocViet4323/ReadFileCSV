using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string filePath = "path_to_your_file.csv";
        List<string> countries = new List<string>();

        try
        {
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] fields = line.Split(',');

                string country = fields[5].Trim('"');

                if (!countries.Contains(country))
                {
                    countries.Add(country);
                }
            }
            Console.WriteLine("Danh sách các quốc gia:");
            foreach (string country in countries)
            {
                Console.WriteLine(country);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
        }
    }
}
