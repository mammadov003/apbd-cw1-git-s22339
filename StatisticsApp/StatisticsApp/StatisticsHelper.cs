namespace StatisticsApp;

public class StatisticsHelper
{
    public static int CalculateSum(int[] values)
    {
        int sum = 0;

        foreach (int value in values)
        {
            sum += value;
        }

        return sum;
    }

    public static double CalculateAverage(int[] values)
    {
        int sum = CalculateSum(values);
        return (double)sum / values.Length;
    }
}