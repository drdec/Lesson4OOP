namespace Lesson4
{
    internal static class GeneratorId
    {
        private static int _id;

        /// <summary>
        /// Возвращает уникальный номер
        /// </summary>
        /// <returns>Id</returns>
        public static int GetId()
        {
            return ++_id;
        }
    }
}
