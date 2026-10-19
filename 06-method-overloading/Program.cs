namespace data_structures_exercises
{
    //Depending on the first line of the input, reads an int, double, or string.
    //If the data type is int, multiply the number by 2.
    //If the data type is real, multiply the number by 1.5
    //If the data type is a string, surround the input with "$".
    internal class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            string value = Console.ReadLine();
            if (dataType == "int")
            {
                value = ManipulateValue(int.Parse(value)).ToString();
            }
            else if (dataType == "double")
            {
                value = ManipulateValue(double.Parse(value)).ToString();
            }
            else
            {
                value =ManipulateValue(value);
            }
            Console.WriteLine(value);
        }
        static int ManipulateValue (int value)
        {
            return value*2;
        }
        static double ManipulateValue(double value)
        {
            return value*1.5;
        }
        static string ManipulateValue(string value)
        {
            return "$" + value + "$";
        }
        
    }
}
