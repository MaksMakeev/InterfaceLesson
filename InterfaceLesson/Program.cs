namespace InterfaceLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadcopter robot = new Quadcopter();
            robot.Charge();
            Console.WriteLine(robot.GetInfo());

            var components = robot.GetComponents();
            foreach (var component in components)
            {
                Console.WriteLine(component);
            }
        }
    }
}
