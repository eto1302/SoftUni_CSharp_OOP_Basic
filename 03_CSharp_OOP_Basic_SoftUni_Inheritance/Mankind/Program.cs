using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            string studentInput = Console.ReadLine();

            string workerInput = Console.ReadLine();
            string[] studentTokens = studentInput.Split(new []{" "},StringSplitOptions.RemoveEmptyEntries);
            string[] workerTokens = workerInput.Split(new []{" "},StringSplitOptions.RemoveEmptyEntries);
            Student student = new Student(studentTokens[0], studentTokens[1], studentTokens[2]);
            Worker worker = new Worker(workerTokens[0], workerTokens[1], decimal.Parse(workerTokens[2]), decimal.Parse(workerTokens[3]));
            Console.WriteLine(student);
            Console.WriteLine(worker);
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
    }
}