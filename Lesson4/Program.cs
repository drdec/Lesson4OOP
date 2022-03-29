using System;

namespace Lesson4
{
    public class Program
    {
        public static void Main()
        {
            var building = new Building();
            var buildingTwo = new Building();

            building.ShowInfo();
            Console.WriteLine();
            buildingTwo.ShowInfo();

        }
    }
    
}
