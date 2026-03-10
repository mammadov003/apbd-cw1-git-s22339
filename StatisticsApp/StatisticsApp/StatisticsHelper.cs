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

    public static int CalculateMax(int[] values)
    {
        int max = values[0];

        foreach (int value in values)
        {
            if (value > max)
            {
                max = value;
            }
        }

        return max;
    }

    public static int CalculateMin(int[] values)
    {
        int min = values[0];

        foreach (int value in values)
        {
            if (value < min)
            {
                min = value;
            }
        }    
        return min;
    }
}