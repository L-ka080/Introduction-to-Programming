using System.Numerics;

#region Task4

// // 1. Даны стороны прямоугольника a и b. Найти его площадь S = a·b и периметр P = 2·(a + b).
// Dictionary<string, int> squareData = Task4.CalculateSquares(12, 63);

// for (int keyIndex = 0; keyIndex < squareData.Keys.Count; keyIndex++)
// {
//     string currentKey = squareData.Keys.ToList()[keyIndex];
//     Console.WriteLine($"{currentKey}: {squareData[currentKey]}");
// }

// Console.WriteLine("-------------");

// // 2. Дан диаметр окружности d. Найти ее длину L = π·d. В качестве значения π использовать 3.14.
// Console.WriteLine($"Circle Length: {Task4.CalculateCircles(5)}");

// Console.WriteLine("-------------");

// // 3. Даны два числа a и b. Найти их среднее арифметическое: (a + b)/2.
// Console.WriteLine($"Avarage: {Task4.CalculateAvarage(3.5f, 19)}");

// Console.WriteLine("-------------");

// // 4. Даны два ненулевых числа. Найти сумму, разность, произведение и частное их квадратов.
// Dictionary<string, float> numbers1 = Task4.CalculateNumbers(12, -25, false);

// Console.WriteLine("-------------");

// for (int keyIndex = 0; keyIndex < numbers1.Keys.Count; keyIndex++)
// {
//     string currentKey = numbers1.Keys.ToList()[keyIndex];
//     Console.WriteLine($"{currentKey}: {numbers1[currentKey]}");
// }

// Console.WriteLine("-------------");

// // 5. Даны два ненулевых числа. Найти сумму, разность, произведение и частное их модулей.
// Dictionary<string, float> numbers2 = Task4.CalculateNumbers(12, -25, true);

// for (int keyIndex = 0; keyIndex < numbers2.Keys.Count; keyIndex++)
// {
//     string currentKey = numbers2.Keys.ToList()[keyIndex];
//     Console.WriteLine($"{currentKey}: {numbers2[currentKey]}");
// }

// Console.WriteLine("-------------");

#endregion

#region Task5

// Vector2 a_vector = new Vector2(1, 2);
// Vector2 b_vector = new Vector2(3, 2);
// Vector2 c_vector = new Vector2(3, 5);

// Tuple<float, float> a_tuple = new(1, 2);
// Tuple<float, float> b_tuple = new(3, 2);
// Tuple<float, float> c_tuple = new(3, 5);

// // 1. Найти расстояние между двумя точками с заданными координатами (x1, y1) и (x2, y2)
// Console.WriteLine($"Расстояние между {a_vector} и {b_vector}: {Task5.CalculateDistance(a_vector, b_vector)}");
// Console.WriteLine($"Расстояние между {a_tuple} и {b_tuple}: {Task5.CalculateDistance(a_tuple, b_tuple)}");

// Console.WriteLine("-------------");

// // 2. Даны три точки A, B, C на числовой оси. Найти длины отрезков AC и BC и их сумму.
// Dictionary<string, float> VectorLengthResults1 = Task5.CalculateVectorsLength(a_vector, b_vector, c_vector);
// Dictionary<string, float> VectorLengthResults2 = Task5.CalculateVectorsLength(a_tuple, b_tuple, c_tuple);

// List<string> VectorLengthResults1Keys = VectorLengthResults1.Keys.ToList();
// List<string> VectorLengthResults2Keys = VectorLengthResults2.Keys.ToList();

// Console.WriteLine($"Длинна {VectorLengthResults1Keys[0]}: {VectorLengthResults1[VectorLengthResults1Keys[0]]}");
// Console.WriteLine($"Длинна {VectorLengthResults2Keys[0]}: {VectorLengthResults2[VectorLengthResults2Keys[0]]}");
// Console.WriteLine($"Длинна {VectorLengthResults1Keys[1]}: {VectorLengthResults1[VectorLengthResults1Keys[1]]}");
// Console.WriteLine($"Длинна {VectorLengthResults2Keys[1]}: {VectorLengthResults2[VectorLengthResults2Keys[1]]}");
// Console.WriteLine($"Сумма {VectorLengthResults1Keys[0]} и {VectorLengthResults1Keys[1]}: {VectorLengthResults1[VectorLengthResults1Keys[2]]}");
// Console.WriteLine($"Сумма {VectorLengthResults2Keys[0]} и {VectorLengthResults2Keys[1]}: {VectorLengthResults2[VectorLengthResults2Keys[2]]}");

// Console.WriteLine("-------------");

// // 3. Даны три точки A, B, C на числовой оси. Точка C расположена между точками A и B. Найти произведение длин отрезков AC и BC
// Console.WriteLine($"Произведение AB и BC: {Task5.VectorLengthMultiplication(a_vector, b_vector, c_vector)}");
// Console.WriteLine($"Произведение AB и BC: {Task5.VectorLengthMultiplication(a_tuple, b_tuple, c_tuple)}");

// Console.WriteLine("-------------");

// // 4. Даны координаты двух противоположных вершин прямоугольника: (x1, y1), (x2, y2). Стороны прямоугольника параллельны осям координат. Найти периметр и площадь данного прямоугольника.
// Console.WriteLine($"Площадь прямоугольника: {Task5.RectangleAreaFromVectors(a_vector, b_vector)}");
// Console.WriteLine($"Периметр прямоугольника: {Task5.RectanglePerimeterFromVectors(a_vector, b_vector)}");

// Console.WriteLine("-------------");

// // 5. Даны координаты трех вершин треугольника: (x1, y1), (x2, y2), (x3, y3). Найти его периметр и площадь
// Dictionary<string, float> CalculateTriangleResults = Task5.CalculateTriangleFromVectors(a_vector, b_vector, c_vector);

// Console.WriteLine($"Площадь треугольника: {CalculateTriangleResults.Values.ToList()[0]}");
// Console.WriteLine($"Периметр треугольника: {CalculateTriangleResults.Values.ToList()[1]}");

// Console.WriteLine("-------------");

#endregion

#region Task25

// 1.
// Task25.FileSymbolClear("D:/Univercity/Расхождения/Введение в программирование/Code/Tasks/Resources/25/1/startFile", "D:/Univercity/Расхождения/Введение в программирование/Code/Tasks/Resources/25/1/endFile");

// 2.
// Task25.CreateFile("stars", "D:/Univercity/Расхождения/Введение в программирование/Code/Tasks/Resources/25/2", 17, 7);

// 3.
// Task25.CombineTwoTextFiles("D:/Univercity/Расхождения/Введение в программирование/Code/Tasks/Resources/25/3/text1.txt", "D:/Univercity/Расхождения/Введение в программирование/Code/Tasks/Resources/25/3/text2.txt", "\n");

// 4.
// Task25.RemoveSpacesFromFile("D:/Univercity/Расхождения/Введение в программирование/Code/Tasks/Resources/25/4/text.txt");

// 5.
// Console.WriteLine(Task25.CountParagraphs("D:/Univercity/Расхождения/Введение в программирование/Code/Tasks/Resources/25/5/text.txt"));

#endregion

#region Task6

// // 1.
// int a1 = 5;
// int b1 = 11;

// Console.WriteLine($"a: {a1}, b: {b1}");

// Task6.Swap(ref a1, ref b1);

// Console.WriteLine($"a: {a1}, b: {b1}");

// // 2.
// int a2 = 6;
// int b2 = 88;
// int c2 = 14;

// Console.WriteLine($"a: {a2}, b: {b2}, c: {c2}");

// Task6.Swap(ref a2, ref c2);
// Task6.Swap(ref b2, ref c2);

// // 14, 6, 88
// Console.WriteLine($"a: {a2}, b: {b2}, c: {c2}");

// // 3.
// int a3 = 3;
// int b3 = 4;
// int c3 = 5;

// Console.WriteLine($"a: {a3}, b: {b3}, c: {c3}");

// Task6.Swap(ref a3, ref c3);
// Task6.Swap(ref a3, ref b3);

// // 4, 5, 3
// Console.WriteLine($"a: {a3}, b: {b3}, c: {c3}");

// // 4.
// float x4 = 2.5f;
// float result4 = 3 * MathF.Pow(x4, 6) - 6 * MathF.Pow(x4, 2) + 2;

// Console.WriteLine(result4);

// // 5.
// float x5 = 2.5f;
// float result5 = 4 * MathF.Pow(x5 - 3, 6) - 7 * MathF.Pow(x5 - 3, 3) + 2;

// Console.WriteLine(result5);

// // 6. 
// Console.WriteLine(Task6.WeirdPow1(2));
// Console.WriteLine(MathF.Pow(2, 8));

// // 7.

// Console.WriteLine(Task6.WeirdPow2(2));
// Console.WriteLine(MathF.Pow(2, 15));

#endregion

#region Task10

// // 1.
// Console.WriteLine(Task10.CheckBoolStatement1(2, 3));

// // 2.
// Console.WriteLine(Task10.CheckBoolStatement2(1, 2, 3));

// // 3.
// Console.WriteLine(Task10.CheckBoolStatement3(12));

// // 4.
// Console.WriteLine(Task10.CheckBoolStatement4(5566));

// // 5.
// Console.WriteLine(Task10.CheckBoolStatement5(5665));

// // 6.
// Console.WriteLine(Task10.CheckBoolStatement6(7, 24, 25));

// // 7.
// Console.WriteLine(Task10.CheckBoolStatement7(7, 24, 25));

#endregion

#region Task11

// // 1.
// Console.WriteLine(Task11.ConvertNumbers(11, 12));

// // 2.
// Console.WriteLine(Task11.SumOfGreatest(13, 14, 15));

// // 3.
// Vector2 a = new Vector2(0, 0);
// Vector2 b = new Vector2(3, 5);
// Vector2 c = new Vector2(1, 2);

// Console.WriteLine(Task11.FindClosestPointToA(a, b, c));

// // 4.
// Console.WriteLine(Task11.FindPointCoordinateQuarter(new Vector2(-1, 2)));

// // 5.
// Console.WriteLine(Task11.TextDescriptionOfNumber1(12));

// // 6.
// Console.WriteLine(Task11.TextDescriptionOfNumber2(362));

#endregion

#region Task15
// // 1.
// for (int i = 2; i < 7; i++)
// {
//     Task15.PowerA3(i, out float B);
//     Console.WriteLine($"{i}^3 = {B}");
// }

// // 2.
// Console.WriteLine(Task15.SighX(15) + Task15.SighX(-5));

// // 3.
// Console.WriteLine(Task15.RingS(15, 12));

// // 4.
// Console.WriteLine(Task15.Quarter(12, -3));

// // 5.
// Console.WriteLine(Task15.Fact2(7));
#endregion