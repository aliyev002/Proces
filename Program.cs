using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Aktiv prosesler:");
            Process[] processes = Process.GetProcesses();

            foreach (var process in processes)
            {
                Console.WriteLine($"ID: {process.Id}, Ad: {process.ProcessName}");
            }

            Console.WriteLine("\nSechim edin: ");
            Console.WriteLine("1. New Task ");
            Console.WriteLine("2. End Task ");
            Console.WriteLine("3. Exit");

            var secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    Console.Write("Yeni prosesin adını daxil edin: ");
                    var yeniProses = Console.ReadLine();

                    Process.Start(yeniProses);
                    Console.WriteLine($"{yeniProses} işə salındı.");

                    break;

                case "2":


                    Console.Write("Dayandırmaq istediyiniz prosesin ID-i daxil edin: ");
                    int processId = int.Parse(Console.ReadLine());
                    Process process = Process.GetProcessById(processId);
                    process.Kill();
                    Console.WriteLine($"Proses {process.ProcessName} dayandırıldı.");
                    break;

                case "3":
                    return;

                default:
                    Console.WriteLine("Duzgun sechim edin.");
                    break;
            }


        }
    }
}
    

