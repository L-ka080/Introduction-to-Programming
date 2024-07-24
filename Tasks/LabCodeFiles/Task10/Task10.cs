public static class Task10
{
    // 1.
    public static bool CheckBoolStatement1(int a, int b)
    {
        return a > 2 && b <= 3;
    }

    // 2. 
    public static bool CheckBoolStatement2(int a, int b, int c)
    {
        return a < b && b < c;
    }

    // 3.
    public static bool CheckBoolStatement3(int value)
    {
        if (value < 0)
        {
            throw new ArgumentException("Value cannot be less than zero");
        }

        if (value % 2 == 0 && value.ToString().Length == 2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // 4.
    public static bool CheckBoolStatement4(int value)
    {
        string stringValue = value.ToString();
        if (stringValue.Length != 3)
        {
            throw new ArgumentException("The number of digits in this number cannot be other than three");
        }

        if (
            (stringValue[0] < stringValue[1] && stringValue[1] < stringValue[2]) ||
            (stringValue[2] < stringValue[1] && stringValue[1] < stringValue[0])
        )
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    // 5.

    public static bool CheckBoolStatement5(int value)
    {
        string stringValue = value.ToString();
        if (stringValue.Length != 4)
        {
            throw new ArgumentException("The number of digits in this number cannot be other than four");
        }

        List<char> digits = stringValue.ToList();

        List<string> valueParts = [
            digits[0].ToString() + digits[1].ToString(),
            digits[2].ToString() + digits[3].ToString()
        ];

        char[] part1 = valueParts[1].ToCharArray();
        Array.Reverse(part1);
        valueParts[1] = new string(part1);

        if (valueParts[0] == valueParts[1])
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // 6.
    public static bool CheckBoolStatement6(int a, int b, int c)
    {
        List<int> sides = [a, b, c];
        int bigSide = sides.Max();
        sides.Remove(bigSide);

        if (MathF.Pow(bigSide, 2) == (MathF.Pow(sides[0], 2) + MathF.Pow(sides[1], 2)))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // 7.
    public static bool CheckBoolStatement7(int a, int b, int c)
    {
        if (
            a + b > c &&
            a + c > b &&
            b + c > a
        )
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}