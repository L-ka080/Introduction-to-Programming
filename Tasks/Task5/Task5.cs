using System.Numerics;

public static class Task5
{
    // 1.
    public static float CalculateDistance(Vector2 vector1, Vector2 vector2)
    {
        return Vector2.Distance(vector1, vector2);
    }

    public static float CalculateDistance(Tuple<float, float> a_tuple, Tuple<float, float> b_tuple)
    {
        return MathF.Sqrt(MathF.Pow(a_tuple.Item1 - b_tuple.Item1, 2) + MathF.Pow(a_tuple.Item2 - b_tuple.Item2, 2));
    }

    // 2.
    public static Dictionary<string, float> CalculateVectorsLength(Vector2 a, Vector2 b, Vector2 c)
    {
        Vector2 vectorAC = c - a;
        Vector2 vectorBC = c - b;

        return new Dictionary<string, float> {
            {nameof(vectorAC), vectorAC.Length()},
            {nameof(vectorBC), vectorBC.Length()},
            {$"Sum of {nameof(vectorAC)} and {nameof(vectorBC)}", vectorAC.Length() + vectorBC.Length()}
        };
    }

    public static Dictionary<string, float> CalculateVectorsLength(Tuple<float, float> a, Tuple<float, float> b, Tuple<float, float> c)
    {
        float vectorACLength = MathF.Sqrt(MathF.Pow(a.Item1 - c.Item1, 2) + MathF.Pow(a.Item2 - c.Item2, 2));
        float vectorBCLength = MathF.Sqrt(MathF.Pow(b.Item1 - c.Item1, 2) + MathF.Pow(b.Item2 - c.Item2, 2));

        return new Dictionary<string, float> {
            {"vectorAC", vectorACLength},
            {"vectorBC", vectorBCLength},
            {$"Sum of vectorAC and vectorBC", vectorACLength + vectorBCLength}
        };
    }

    // 3.
    public static float VectorLengthMultiplication(Vector2 a, Vector2 b, Vector2 c)
    {
        Vector2 vectorAC = c - a;
        Vector2 vectorBC = c - b;

        return vectorAC.Length() * vectorBC.Length();
    }

    public static float VectorLengthMultiplication(Tuple<float, float> a, Tuple<float, float> b, Tuple<float, float> c)
    {
        float vectorACLength = MathF.Sqrt(MathF.Pow(a.Item1 - c.Item1, 2) + MathF.Pow(a.Item2 - c.Item2, 2));
        float vectorBCLength = MathF.Sqrt(MathF.Pow(b.Item1 - c.Item1, 2) + MathF.Pow(b.Item2 - c.Item2, 2));

        return vectorACLength * vectorBCLength;
    }

    // 4.
    public static float RectangleAreaFromVectors(Vector2 a, Vector2 b)
    {
        float diagonalLength = (b - a).Length();

        float longSideLength = (new Vector2(b.X, 0f) - new Vector2(a.X, 0f)).Length();

        return longSideLength * MathF.Sqrt(MathF.Pow(diagonalLength, 2) - MathF.Pow(longSideLength, 2));

    }


    public static float RectanglePerimeterFromVectors(Vector2 a, Vector2 b)
    {
        float diagonalLength = (b - a).Length();

        float longSideLength = (new Vector2(b.X, 0f) - new Vector2(a.X, 0f)).Length();

        return 2 * (longSideLength + MathF.Sqrt(MathF.Pow(diagonalLength, 2) - MathF.Pow(longSideLength, 2)));
    }

    // 5.
    public static Dictionary<string, float> CalculateTriangleFromVectors(Vector2 a, Vector2 b, Vector2 c)
    {
        float ABLength = (b - a).Length();
        float BCLength = (b - c).Length();
        float ACLength = (c - a).Length();

        float Area = MathF.Abs((b.X - a.X) * (c.Y - a.Y) - (c.X - a.X) * (b.Y - a.X)) / 2f;
        float Perimeter = ABLength + BCLength + ACLength;

        return new Dictionary<string, float> {
            {
                "Area", Area
            },
            {
                "Perimeter", Perimeter
            }
        };
    }
}