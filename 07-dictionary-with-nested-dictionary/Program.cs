namespace data_structures_exercises
{
    //you receive the following input until you receive the command "end"
    //C#-Peter-90
    //JS-Maria-85
    //You need to print each student, the exams they took, and the points they received.
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string,Dictionary<string,int>> students = new Dictionary<string,Dictionary<string,int>>();
            while (command!="end")
            {
                string[]input = command.Split("-").ToArray();
                if (students.ContainsKey(input[1]))
                {
                    students[input[1]].Add(input[0], int.Parse(input[2]));
                }
                else
                {
                    students.Add(input[1],new Dictionary<string, int>());
                    students[input[1]].Add(input[0],int.Parse(input[2]));
                }
                    command = Console.ReadLine();
            }
            foreach (var student in students)
            {
                Console.WriteLine(student.Key);
                int sum = 0;
                foreach (var exam in student.Value)
                {
                    Console.WriteLine($"{exam.Key} - {exam.Value}");
                    sum += exam.Value;
                }
                Console.WriteLine($"Total points: {sum}");
            }
        }
    }
}
