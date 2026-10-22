namespace _10_browser_navigation_with_Stack
{
    //After each instruction, the program should print the current URL.
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            var urls = new Stack<string>();
            while (command != "Home")
            {
                if(command == "Back")
                {
                    if(urls.Count <= 1)
                    {
                        Console.WriteLine("No previous URLs");
                    }
                    else
                    {
                        urls.Pop();
                        Console.WriteLine(urls.Peek());
                    }
                }
                else
                {
                    urls.Push(command);
                    Console.WriteLine(urls.Peek());
                }
                command = Console.ReadLine();
            }
        }
    }
}
