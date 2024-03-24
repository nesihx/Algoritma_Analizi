
public class Karatsuba
{
    public static long Multiply(long x, long y)
    {
        if (x < 10 || y < 10)
            return x * y;

        int maxLength = Math.Max(x.ToString().Length, y.ToString().Length);
        int halfLength = maxLength / 2;

        long xLow = x % (long)Math.Pow(10, halfLength);
        long xHigh = x / (long)Math.Pow(10, halfLength);
        long yLow = y % (long)Math.Pow(10, halfLength);
        long yHigh = y / (long)Math.Pow(10, halfLength);

        long z0 = Multiply(xLow, yLow);
        long z2 = Multiply(xHigh, yHigh);
        long z1 = Multiply(xLow + xHigh, yLow + yHigh) - z2 - z0;

        return z2 * (long)Math.Pow(10, 2 * halfLength) + z1 * (long)Math.Pow(10, halfLength) + z0;
    }

    public static void Main(string[] args)
    {
        long A = 2135;
        long B = 4014;
        long result = Multiply(A, B);
        Console.WriteLine($"{A} x {B} = {result}");
    }
}