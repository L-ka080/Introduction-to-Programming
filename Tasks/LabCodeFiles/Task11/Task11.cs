using System.Numerics;

public static class Task11
{
    // 1.
    public static Tuple<int, int> ConvertNumbers(int a, int b)
    {
        List<int> values = [a, b];
        if (a != b)
        {
            a = values.Max();
            b = values.Max();
        }
        else
        {
            a = 0;
            b = 0;
        }

        return new(a, b);
    }

    // 2.
    public static int SumOfGreatest(params int[] values)
    {
        List<int> listedValues = values.ToList();

        int bigNumber1 = listedValues.Max();
        listedValues.Remove(bigNumber1);

        int bigNumber2 = listedValues.Max();
        listedValues.Remove(bigNumber2);

        return bigNumber1 + bigNumber2;
    }

    // 3.
    public static Tuple<Vector2, float> FindClosestPointToA(Vector2 a, Vector2 b, Vector2 c)
    {
        float distanceFromC = Vector2.Distance(c, a);
        float distanceFromB = Vector2.Distance(b, a);

        if (distanceFromC < distanceFromB)
        {
            return new(c, distanceFromC);
        }
        else if (distanceFromC > distanceFromB)
        {
            return new(b, distanceFromB);
        }
        else
        {
            return new(b, distanceFromB);
        }
    }

    // 4.
    public static int FindPointCoordinateQuarter(Vector2 a)
    {
        if (a.X >= 0 && a.Y >= 0) return 1;
        else if (a.X < 0 && a.Y >= 0) return 2;
        else if (a.X < 0 && a.Y < 0) return 3;
        else if (a.X >= 0 && a.Y < 0) return 4;
        else return -1;
    }

    // 5.
    public static string TextDescriptionOfNumber1(int value)
    {
        if (value > 0 && value % 2 == 0)
        {
            return $"{value}: чётное положительное число";
        }
        else if (value > 0 && value % 2 != 0)
        {
            return $"{value}: нечётное положительное число";
        }
        else if (value < 0 && value % 2 == 0)
        {
            return $"{value}: чётное отрицательное число";
        }
        else if (value < 0 && value % 2 != 0)
        {
            return $"{value}: нечётное отрицательное число";
        }
        else
        {
            return $"{value}: это ноль";
        }
    }

    // 6.
    public static string TextDescriptionOfNumber2(int value)
    {
        if (value < 1 || value > 999)
        {
            throw new ArgumentException("The value is outside the range 1-999");
        }

        string stringValue = value.ToString();

        if (value % 2 == 0 && stringValue.Length == 1)
        {
            return $"{value}: чётное однозначное число";
        }
        else if (value % 2 == 0 && stringValue.Length == 2)
        {
            return $"{value}: чётное двузначное число";
        }
        else if (value % 2 == 0 && stringValue.Length == 3)
        {
            return $"{value}: чётное трёхзначное число";
        }
        else if (value % 2 != 0 && stringValue.Length == 1)
        {
            return $"{value}: нечётное однозначное число";
        }
        else if (value % 2 != 0 && stringValue.Length == 2)
        {
            return $"{value}: нечётное двузначное число";
        }
        else if (value % 2 != 0 && stringValue.Length == 3)
        {
            return $"{value}: нечётное трёхзначное число";
        }

        return "";
    }
}