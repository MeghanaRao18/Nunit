namespace PrimeService;

public class PrimeService
{
        public bool IsPrime(int candidate)
        {
            bool result = false;
            if (candidate <=1)
            {
                return result;
            }
            else
            {
                for(int i = 2; i < candidate;)
                {
                    if (candidate % i == 0)
                        result = true;
                        break;                  
                }
            }
            return result;

        }
}
