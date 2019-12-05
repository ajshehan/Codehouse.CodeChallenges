namespace Codehouse.CodeChallenges.Business
{

    /// <summary>
    /// Sample challenge:
    /// Accept an array object and calculate the sum of all the integers
    /// </summary>
    public class Sample
    {
        public int? AddIntegers(object[] array)
        {
            if (array == null || array.Length == 0)
            {
                return null;
            }

            int? sum = null;
            for (var i = 0; i < array.Length; i++)
            {
                if (!(array[i] is int))
                {
                    continue;
                }

                if (sum == null)
                {
                    sum = 0;
                }

                sum += (int) array[i];
            }

            return sum;
        }
    }
}
