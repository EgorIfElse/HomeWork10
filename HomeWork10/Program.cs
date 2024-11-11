namespace HomeWork10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Angle angle;
            do
            {
                Console.WriteLine("Введите значения");
                angle = new Angle(' ', ' ', ' ');
                angle.Gradus = Convert.ToInt32(Console.ReadLine());
                angle.Minutes = Convert.ToInt32(Console.ReadLine());
                angle.Seconds = Convert.ToInt32(Console.ReadLine());
            }
            while (angle.itscorrect == false);
            double toRadins = angle.ToRadians();
            Console.WriteLine(toRadins);
        }
    }
}
