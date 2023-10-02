namespace PracticeProblemsGeneric
{
    internal class DeletyeArray
    {
        public void DeleteMethodInt()
        {
            Console.WriteLine("Give size of arry");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Add elements");
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter element to delete");
            int element = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(element))
                {
                    array[i] = default(int);
                    break;
                }
            }
            Console.WriteLine("Array is");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }

        public void DeleteMethodDouble()
        {
            Console.WriteLine("Give size of arry");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] array = new double[n];
            Console.WriteLine("Add elements");
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter element to delete");
            int element = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(element))
                {
                    array[i] = default(double);
                    break;
                }
            }
            Console.WriteLine("Array is");
            foreach (double i in array)
            {
                Console.WriteLine(i);
            }
        }

        public void DeleteMethodChar()
        {
            Console.WriteLine("Give size of arry");
            int n = Convert.ToInt32(Console.ReadLine());
            char[] array = new char[n];
            Console.WriteLine("Add elements");
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("Enter element to delete");
            int element = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(element))
                {
                    array[i] = default(char);
                    break;
                }
            }
            Console.WriteLine("Array is");
            foreach (char i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}
