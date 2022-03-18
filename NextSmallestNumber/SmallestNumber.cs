
namespace NextSmallestNumber
{
    public class SmallestNumber
    {
        public int GetNextSmallestNumber(int[] positiveSortedArray, int smallestInt)
        {
            try
            {
                var stack = new Stack<int>();

                foreach (int i in positiveSortedArray)
                {
                    if (i < smallestInt || i == smallestInt)
                    {
                        stack.Push(i);
                    }
                }

                if (stack.Count > 0)
                    return stack.Peek();

                return -1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
