public static class Task1
{
    // 1.
    public static Dictionary<string, int> CalculateSquares(int a, int b)
    {
        int area = a * b;
        int perimeter = 2 * (a + b);

        return new Dictionary<string, int> {
            {"Area", area},
            {"Perimeter", perimeter}
        };
    }

    // 2.
    public static float CalculateCircles(float diameter)
    {
        return 3.14f * diameter;
    }

    // 3.
    public static float CalculateAvarage(float a, float b)
    {
        return MathF.Round((a + b) / 2, 5);
    }

    public static Dictionary<string, float> CalculateNumbers(float a, float b, bool isMod = false)
    {
        if (a == 0 || b == 0) throw new ArgumentException("Parameters cannot be equal to zero");

        if (isMod)
        {
            return new Dictionary<string, float> {
                {"Sum", a+b},
                {"Substract", a-b},
                {"Division of squares", MathF.Pow(a, 2) / MathF.Pow(b, 2)},
            };
        }
        else
        {
            a = MathF.Abs(a);
            b = MathF.Abs(b);

            return new Dictionary<string, float> {
                {"Sum", a+b},
                {"Substract", a-b},
                {"Division of squares", MathF.Pow(a, 2) / MathF.Pow(b, 2)},
            };
        }
    }
}