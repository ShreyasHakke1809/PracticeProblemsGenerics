namespace PracticeProblemsGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n1.Find minimum int\n2.Find minimum float\n3.Find minimum string\n4.Find minimum using generics" +
                "\n5.Find minimum using generics using Constructor\n6.Delete Element in Array\n7.Delete Element in Array using generic class" +
                "\n8.Delete Element in Array using generic method\n9.Exit");
            bool loopAgain = true;
            while (loopAgain)
            {
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FindMinimumInt findMaximumInt = new FindMinimumInt();
                        int z = findMaximumInt.MinOfThree(10, 20, 30);
                        Console.WriteLine(z);
                        break;
                    case 2:
                        FindMinimumFloat findMaximumFloat = new FindMinimumFloat();
                        float y = findMaximumFloat.Min(10f, 20f, 30f);
                        Console.WriteLine(y);
                        break;
                    case 3:
                        FindMinimumString findMaximumString = new FindMinimumString();
                        string x = findMaximumString.Min("abc", "pqr", "xyz");
                        Console.WriteLine(x);
                        break;
                    case 4:
                        FindMinimumUsingGenerics findMinimumUsingGenerics = new FindMinimumUsingGenerics();
                        findMinimumUsingGenerics.GetMinOfThree("a", "b", "c");
                        break;
                    case 5:
                        int a = 09; int b = 18; int c = 27;
                        int max = new FindMinimum<int>(a, b, c).GetMin();
                        Console.WriteLine("Minimum out of {0}, {1}, {2} integers is: {3}", a, b, c, max);
                        float p = 27.09f; float q = 45.18f; float r = 72.99f;
                        float fmax = new FindMinimum<float>(p, q, r).GetMin();
                        Console.WriteLine("Minimum out of {0}, {1}, {2} float is: {3}", p, q, r, fmax);
                        string l = "Xyz"; string k = "Abc"; string m = "Pqr";
                        string smax = new FindMinimum<string>(l, k, m).GetMin();
                        Console.WriteLine("Minimum out of {0}, {1}, {2} string is: {3}", l, k, m, smax);
                        break;
                    case 6:
                        DeletyeArray array = new DeletyeArray();
                        array.DeleteMethodInt();
                        array.DeleteMethodDouble();
                        array.DeleteMethodChar();
                        break;
                    case 7:
                        int[] intArray = { 1, 2, 3, 4, 5 };
                        double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5 };
                        char[] charArray = { 'a', 'b', 'c', 'd', 'e' };
                        DeleteArrayGenericClass<int> deleteIntArray = new DeleteArrayGenericClass<int>(intArray);
                        deleteIntArray.DeleteMethod(3);
                        DeleteArrayGenericClass<double> deleteDoubleArray = new DeleteArrayGenericClass<double>(doubleArray);
                        deleteDoubleArray.DeleteMethod(4.4);
                        DeleteArrayGenericClass<char> deleteCharArray = new DeleteArrayGenericClass<char>(charArray);
                        deleteCharArray.DeleteMethod('c');
                        Console.WriteLine("Updated intArray: " + string.Join(", ", intArray));
                        Console.WriteLine("Updated doubleArray: " + string.Join(", ", doubleArray));
                        Console.WriteLine("Updated charArray: " + string.Join(", ", charArray));
                        break;
                    case 8:
                        DeleteArrayGenericMethod<int> arrayGenericMethod = new DeleteArrayGenericMethod<int>();
                        arrayGenericMethod.DeleteMethod();
                        DeleteArrayGenericMethod<char> arrayGenericMetho = new DeleteArrayGenericMethod<char>();
                        arrayGenericMetho.DeleteMethod();
                        break;
                    case 9:
                        Environment.Exit(0);
                        break;
                    case 10:
                        loopAgain = false;
                        break;
                }
            }
        }
    }
}