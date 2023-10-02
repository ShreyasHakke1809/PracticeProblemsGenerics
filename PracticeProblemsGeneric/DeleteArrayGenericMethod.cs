namespace PracticeProblemsGeneric
{
    internal class DeleteArrayGenericMethod<T>
    {
        public void DeleteMethod()
        {
            Console.WriteLine("Give size of arry");
            int n = Convert.ToInt32(Console.ReadLine());
            T[] array = new T[n];
            Console.WriteLine("Add elements");
            //var opt = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                var opt = Console.ReadLine();
                array[i] = (T)Convert.ChangeType(opt, typeof(T));
            }
            Console.WriteLine("Enter element to delete");
            int element = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(element))
                {
                    array[i] = default(T);
                    break;
                }
            }
            Console.WriteLine("Array is");
            foreach (T i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}
