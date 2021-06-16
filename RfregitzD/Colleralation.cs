/*https://stackoverflow.com/questions/8869006/multiple-dimension-correlation-in-c-sharp*/

namespace ImageTextDeepLearning
{
    public class Colleralation
    {
        static double Threshold = 0.2;
        public static int GetCorrelationScore(bool[,] seriesA, bool[,] seriesB, int n, int Order)
        {
            int correlationScore = 0;

            for (var i = 0; i < //seriesA.Length
                n; i++)
            {
                bool A = true;
                for (var j = 0; j < n; j++)
                {
                    if (Order == 1 && seriesA[i, j])
                    {
                        A = areEqual(System.Convert.ToDouble(seriesA[i, j]), System.Convert.ToDouble(seriesB[i, j]), Threshold
                        );
                        if (A)
                            correlationScore++;
                    }
                    else
                    {
                        if (Order == -1 && (!seriesA[i, j]))
                        {
                            A = areEqual(System.Convert.ToDouble(seriesA[i, j]), System.Convert.ToDouble(seriesB[i, j]), Threshold
                           );
                            if (A)
                                correlationScore++;
                        }
                    }
                }
            }
            return correlationScore;
        }
        public static int GetCorrelationScore(int[,] seriesA, int[,] seriesB, int n, int Order)
        {
            int correlationScore = 0;

            for (var i = 0; i < //seriesA.Length
                n; i++)
            {
                bool A = true;
                for (var j = 0; j < n; j++)
                {
                    if (Order == 1 && seriesA[i, j] > 0)
                    {
                        A = areEqual(System.Convert.ToDouble(seriesA[i, j]), System.Convert.ToDouble(seriesB[i, j]), Threshold
                            );
                        if (A)
                            correlationScore++;
                    }
                    else
                    {
                        if (Order == -1 && seriesA[i, j] < 0)
                        {
                            A = areEqual(System.Convert.ToDouble(seriesA[i, j]), System.Convert.ToDouble(seriesB[i, j]), Threshold
                            );
                            if (A)
                                correlationScore++;
                        }
                    }
                }
            }
            return correlationScore;
        }

        static bool areEqual(double value1, double value2, double allowedVariance)
        {
            var lowValue1 = value1 - allowedVariance;
            var highValue1 = value1 + allowedVariance;

            return (lowValue1 < value2 && highValue1 > value2);
        }


    }
}