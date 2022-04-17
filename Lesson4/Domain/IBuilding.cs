namespace Lesson4.Domain
{
    public interface IBuilding
    {
        int Id { get; }
        int Height { get; set; }
        int NumberOfFloor { get; set; }
        int NumberOfApartments { get; set; }
        int NumberOfEntrances { get; set; }
        double GetFloorHeight();
        double GetNumberOfApartmentsInEntrance();
        double GetNumberOfApartmentsInFloor();
        void ShowInfo();
    }
}
