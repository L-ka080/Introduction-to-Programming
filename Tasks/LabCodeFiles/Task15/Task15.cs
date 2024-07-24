public static class Task15
{
    // 1.
    public static void PowerA3(float A, out float B)
    {
        B = MathF.Pow(A, 3);
    }

    // 2.
    public static int SighX(float X)
    {
        if (X < 0) return -1;
        else if (X > 0) return 1;
        else return 0;
    }

    // 3.
    public static float RingS(float R1, float R2)
    {
        return 3.14f * (MathF.Pow(R1, 2) - MathF.Pow(R2, 2));
    }

    // 4.
    public static int Quarter(int x, int y)
    {
        if (x >= 0 && y >= 0) return 1;
        else if (x < 0 && y >= 0) return 2;
        else if (x < 0 && y < 0) return 3;
        else if (x >= 0 && y < 0) return 4;
        else return -1;
    }

    // 5.
    public static float Fact2(int N)
    {
        float result = 1f;
        if (N % 2 == 0)
        {
            for (int i = 2; i <= N; i += 2)
            {
                result *= i;
            }
        }
        else
        {
            for (int i = 3; i <= N; i += 2)
            {
                result *= i;
            }
        }

        return result;
    }
}