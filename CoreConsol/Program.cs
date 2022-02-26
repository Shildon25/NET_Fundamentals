using System;
using HelloLibrary;
class Program
{
    static void Main (string[] args)
    {
        try
        {
            string username = args[0];
            Console.WriteLine(ConcatDate.AddDate($"Hello, {username}"));
        }
        catch
        {
            Console.WriteLine ("Username argument is invalid or empty");
        }
    }
}

