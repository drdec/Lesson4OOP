using System;

namespace Lesson4
{
    public class Building : IBuilding
    {
        private readonly int _id;
        private int _height;
        private int _numberOfFloor;
        private int _numberOfApartments;
        private int _numberOfEntrances;

        #region свойства класса
        /// <summary>
        /// Уникальный номер здания
        /// </summary>
        public int Id => _id;

        /// <summary>
        /// Высота здания
        /// </summary>
        public int Height
        {
            get => _height;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Высота здания должна быть больше нуля", nameof(value));
                }
                else
                {
                    _height = value;
                }
            }
        }

        /// <summary>
        /// Количество этажей здания
        /// </summary>
        public int NumberOfFloor
        {
            get => _numberOfFloor;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Количество этажей должно быть больше нуля", nameof(value));
                }
                else
                {
                    _numberOfFloor = value;
                }
            }
        }

        /// <summary>
        /// Количество квартир в здании
        /// </summary>
        public int NumberOfApartments
        {
            get => _numberOfApartments;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Количество квартир должно быть больше нуля", nameof(value));
                }
                else
                {
                    _numberOfApartments = value;
                }
            }
        }

        /// <summary>
        /// Количество входов/подъездов в здании
        /// </summary>
        public int NumberOfEntrances
        {
            get => _numberOfEntrances;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Количество подъездов/входов должно быть больше нуля", nameof(value));
                }
                else
                {
                    _numberOfEntrances = value;
                }
            }
        }

        #endregion

        /// <summary>
        /// Возвращает среднюю высоту этажа
        /// </summary>
        /// <returns></returns>
        public double GetFloorHeight() => (double) Height / NumberOfFloor;

        /// <summary>
        /// Возвращает среднее количество квартир в подъезде
        /// </summary>
        /// <returns></returns>
        public double GetNumberOfApartmentsInEntrance() => (double) NumberOfApartments / NumberOfEntrances;

        /// <summary>
        /// Возвращает среднее количество квартир на этаже
        /// </summary>
        /// <returns></returns>
        public double GetNumberOfApartmentsInFloor() => (double) NumberOfApartments / NumberOfFloor;

        public Building(int height = 1, int numberOfFloor = 1, int numberOfApartments = 1, int numberOfEntrances = 1)
        {
            _id = GeneratorId.GetId();
            Height = height;
            NumberOfFloor = numberOfFloor;
            NumberOfApartments = numberOfApartments;
            NumberOfEntrances = numberOfEntrances;
        }

        /// <summary>
        /// Вывод информации о здании
        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine($"Уникальный номер здания - {Id}\n" +
                              $"Высота - {Height}\n" +
                              $"Количество этажей - {NumberOfFloor}\n" +
                              $"Количество квартир - {NumberOfApartments}\n" +
                              $"Количество входов/подъездов - {NumberOfEntrances}");
        }
    }
}
