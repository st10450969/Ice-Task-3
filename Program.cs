namespace Ice_Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape rectangle = new Rectangle("Rectangle", 5, 10);
            IShape circle = new Circle("Circle", 5);

            rectangle.Display();
            Console.WriteLine();
            circle.Display();
        }
    }
}
