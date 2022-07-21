namespace General_Problem_Solving
{
    internal partial class Program
    {
        public class Racer
        {
            private readonly string name;

            public Racer(string name)
            {
                this.name = name;
            }

            public void Run()
            {
                Thread.Sleep(100);
                Console.WriteLine(name);
            }
        }
    }
}