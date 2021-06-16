
namespace ImageTextDeepLearning
{
    public class Colleralation
    {
        private static readonly double Threshold = 0.2;
        public static int GetCorrelationScore(bool[,] seriesA, bool[,] seriesB, int n)
        {
            int correlationScore = 0;
            for (int i = 0; i < 
                n; i++)
            {
                bool A = true;
                for (int j = 0; j < n; j++)
                {
                    A = areEqual(System.Convert.ToDouble(seriesA[i, j]), System.Convert.ToDouble(seriesB[i, j]), Threshold
                        );
                    if (A)
                    {
                        correlationScore++;
                    }
                    else
                    {
                        correlationScore--;
                    }
                }
            }
            return correlationScore;
        }
        public static int GetCorrelationScore(int[,] seriesA, int[,] seriesB, int n)
        {
            int correlationScore = 0;
            for (int i = 0; i < 
                n; i++)
            {
                bool A = true;
                for (int j = 0; j < n; j++)
                {
                    A = areEqual(System.Convert.ToDouble(seriesA[i, j]), System.Convert.ToDouble(seriesB[i, j]), Threshold
                        );
                    if (A)
                    {
                        correlationScore++;
                    }
                    else
                    {
                        correlationScore--;
                    }
                }
            }
            return correlationScore;
        }
        private static bool areEqual(double value1, double value2, double allowedVariance)
        {
            double lowValue1 = value1 - allowedVariance;
            double highValue1 = value1 + allowedVariance;
            return (lowValue1 < value2 && highValue1 > value2);
        }

    }
}
