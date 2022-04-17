using System;
using System.Collections.Generic;

namespace Lesson4
{
    public static class ListBuilding
    {
        private static HashSet<IBuilding> _listBuildings = new HashSet<IBuilding>();

        public static void AddBuilding(IBuilding building)
        {
            _listBuildings.Add(building);
        }

        public static void DeleteBuilding(IBuilding building)
        {
            _listBuildings.Remove(building);
            building = null;
            GC.Collect();
        }

        public static void ShowAllBuilding()
        {
            foreach (var i in _listBuildings)
            {
                i.ShowInfo();
                Console.WriteLine("================================");
            }
        }
    }
}
