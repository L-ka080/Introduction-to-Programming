using System.IO;
using System.Text;

public static class Task25
{
    // 1.
    public static void FileSymbolClear(string filePath, string saveToFilePath)
    {
        using StreamReader fileReadFrom = new(filePath);
        string fileText = fileReadFrom.ReadToEnd();

        List<string> splittedText = fileText.Split(null).ToList();
        splittedText.RemoveAt(0);

        string resultString = "";

        for (int i = 0; i < splittedText.Count; i++)
        {
            resultString = string.Join(' ', splittedText);
        }
        
        using StreamWriter fileToSaveTo = new(saveToFilePath);
        fileToSaveTo.Write(resultString);

        fileReadFrom.Close();
        fileToSaveTo.Close();
    }

    // 2.
    public static void CreateFile(string fileName, string filePath, int n, int k)
    {
        filePath = Path.Combine(filePath + $"/{fileName}.txt");

        using StreamWriter fileToWriteTo = new(filePath);
        for (int i = 0; i < n; i++)
        {
            if (i == n - 1)
            {
                fileToWriteTo.Write(new string('*', k));
                continue;
            }

            fileToWriteTo.WriteLine(new string('*', k));
        }
    }

    // 3.
    public static void CombineTwoTextFiles(string fileReadFromPath, string fileWriteToPath, string? separetor = null)
    {
        using StreamReader fileReadFrom = new(fileReadFromPath);
        using StreamReader fileWriteToRead = new(fileWriteToPath);

        string fileReadFromText = fileReadFrom.ReadToEnd();

        string newText = "";

        if (separetor == null)
        {
            newText = fileReadFromText;
            newText += fileWriteToRead.ReadToEnd();
        }
        else
        {
            newText = fileReadFromText + separetor;
            newText += fileWriteToRead.ReadToEnd();
        }

        using StreamWriter fileToWriteTo = new(fileWriteToPath);

        fileWriteToRead.Close();
        fileToWriteTo.WriteLine(newText);

        fileReadFrom.Close();
        fileToWriteTo.Close();
    }

    // 4.
    public static void RemoveSpacesFromFile(string filePath)
    {
        List<string> fileText = File.ReadAllLines(filePath).ToList();

        using StreamWriter fileEdit = new(filePath);
        StringBuilder sb = new();

        foreach (string line in fileText)
        {
            bool lastWasSpace = false;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == ' ')
                {
                    if (!lastWasSpace)
                    {
                        sb.Append(line[i]);
                        lastWasSpace = true;
                    }
                }
                else
                {
                    sb.Append(line[i]);
                    lastWasSpace = false;
                }
            }
            sb.AppendLine();
        }

        fileEdit.Write(sb.ToString());
    }
    // 5.
    public static int CountParagraphs(string filePath)
    {
        List<string> lines = File.ReadAllLines(filePath).ToList();

        int paragraphCount = 0;

        foreach (string line in lines)
        {
            if (line.StartsWith("    ") && line.Any(char.IsLetter))
            {
                paragraphCount++;
            }
        }

        return paragraphCount;
    }
}