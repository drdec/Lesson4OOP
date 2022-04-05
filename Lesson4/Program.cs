namespace Lesson4
{
    public class Program
    {
        public static void Main()
        {
            var temp = Creator.CreateBuilding();
            temp.ShowInfo();
            ListBuilding.ShowAllBuilding();
            ListBuilding.DeleteBuilding(temp);
        }
    }
    
}
