using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.Domain
{
    public class Khrushchevka : IBuilding
    {
        public int Id => throw new NotImplementedException();

        public int Height { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int NumberOfFloor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int NumberOfApartments { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int NumberOfEntrances { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public double GetFloorHeight()
        {
            throw new NotImplementedException();
        }

        public double GetNumberOfApartmentsInEntrance()
        {
            throw new NotImplementedException();
        }

        public double GetNumberOfApartmentsInFloor()
        {
            throw new NotImplementedException();
        }

        public void ShowInfo()
        {
            throw new NotImplementedException();
        }
    }
}
