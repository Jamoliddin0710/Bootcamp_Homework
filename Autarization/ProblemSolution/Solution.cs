namespace Autarization.ProblemSolution
{
    public class Solution
    {
        public int SongachaUchlar(long n , int k)
        {
            int sum = 0;
            for (int i = k; i <= n; i++)
            {
                sum += SonTakrorlanishi(i,k);
            }
            return sum;
        }

        private int SonTakrorlanishi(long son ,int k)
        {
            int ry = 0;
            while (son > 0)
            {
                if (son % 10 == k) { ry++; }
                son /= 10;

            }
            return ry;
        }
    }
}
