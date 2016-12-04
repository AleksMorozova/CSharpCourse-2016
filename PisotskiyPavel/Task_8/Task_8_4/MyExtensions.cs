using Task_8_2;

namespace Task_8_4
{
    static class MyExtensions
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] array = new T[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                array[i] = list[i];
            }

            return array;
        }
    }
}
