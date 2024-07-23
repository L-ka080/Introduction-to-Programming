public static class Task6
{
    // 1., 2., 3.
    public static void Swap(ref int a, ref int b)
    {
        (a, b) = (b, a);
    }

    public static float WeirdPow1(float a)
    {
        float result = a;

        result *= result;
        result *= result;
        result *= result;

        return result;
    }

    public static float WeirdPow2(float a)
    {
        float temp1 = a * a; // ^2
        temp1 *= a; // ^3
        
        float temp2 = temp1 * temp1; // ^6

        temp2 *= temp2; // ^12

        temp2 *= temp1; // ^15

        // 2, 3 (2+1), 6(3+3), 12(6+6), 15(12+3)
        
        return temp2;        
    }
}