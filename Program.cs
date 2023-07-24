
using System.Security.Cryptography.X509Certificates;

namespace CsharpZoo

{

    internal class Zoo

    {
        static void Main(string[] args)
        {
            Rhino rhino = new Rhino();
            rhino.Charge();

            Monkey monkey = new Monkey();
            monkey.Sleep();
            monkey.Move();

            Eagle eagle = new Eagle();
            eagle.Fly();

/*            Shark shark = new Shark();
            shark.Sleep();
            shark.Move();
            shark.Eat();*/

            Frog frog = new Frog();
            frog.Move();
            frog.Sleep();

        }

    }
}