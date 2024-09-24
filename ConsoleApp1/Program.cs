using System.Diagnostics;

namespace lesson1;

class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
            var processes = Process.GetProcesses();
           
            for (int i = 1; i < processes.Length; i++)
            {
                Console.WriteLine($"{i}){processes[i].ProcessName}");
            }
            Console.Write("Choice:");
            Console.WriteLine("1)New Task");
            Console.Write("2)End Task");
            short choice=short.Parse(Console.ReadLine());
           
            if(choice == 1)
            {
                string processName= Console.ReadLine();
                var process=Process.Start(processName);
            }
            else if (choice == 2)
            {
                Console.Write("Enter id for kill process:");
                int processId=int.Parse(Console.ReadLine());
                var processs=Process.GetProcessById(processId);
                processs.Kill();
               
                Console.WriteLine("Proses Kill olundu");
                

            }
        }
    }
}