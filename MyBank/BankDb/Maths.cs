namespace BankDb
{
    public class Maths
    {
        public int AddIntegers(int first, int second)
        {
            int sum = first;
            for( int i = 0; i < second; i++)
            {
                sum += 1;
            }
            return sum;
        }
    }
}