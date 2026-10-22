namespace _11_order_of_files_with_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            var files = new Queue<string>();
            while(command!="print")
            {
                if (command == "cancel" && files.Count > 0)
                { 
                    Console.WriteLine($"Cancel {files.Dequeue()}");
                }
                else if(command=="cancel" && files.Count==0)
                {
                    Console.WriteLine("StandBy");
                }
                else
                {
                    files.Enqueue(command);
                }
                command = Console.ReadLine();
            }
            while (files.Count>0)
            {
                Console.WriteLine(files.Dequeue());
            }

        }
    }
}
