namespace Lesson4
{
    public class Creator
    {
        private Creator() {}

        public static IBuilding CreateBuilding(int height = 1, int numberOfFloor = 1, int numberOfApartments = 1,
            int numberOfEntrances = 1)
        {
            IBuilding temp = new Building(height, numberOfFloor, numberOfApartments, numberOfEntrances);
            ListBuilding.AddBuilding(temp);
            return temp;
        }
        
    }
}
