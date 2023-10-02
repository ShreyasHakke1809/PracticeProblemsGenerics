namespace PracticeProblemsGeneric
{
    internal class DeleteArrayGenericClass<T>
    {
        private T[] array;

        public DeleteArrayGenericClass(T[] array)
        {
            this.array = array;
        }

        public void DeleteMethod(T element)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(element))
                {
                    array[i] = default(T);
                    break;
                }
            }
        }
    }
}
