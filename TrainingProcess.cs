using System;
using System.IO;

namespace KeyboardTraining
{
    public class TrainingProcess
    {
        private readonly Random rnd = new Random();
        public string GetText()
        {
            string Result;
            StreamReader streamReader;

            switch (rnd.Next(3))
            {
                case 1:
                    if (Properties.Settings.Default.TextLanguage == "en-US")
                    {
                        if (Properties.Settings.Default.TextDifficulty == "Common")
                        {
                            switch (Properties.Settings.Default.Mode)
                            {
                                case "Text":
                                    try
                                    {
                                        streamReader = new StreamReader("Texts\\en-US\\Common\\Text\\Text1.txt");
                                        Result = streamReader.ReadToEnd();
                                        return Result;
                                    }
                                    catch (FileNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                case "Words":
                                    try
                                    {
                                        streamReader = new StreamReader("Texts\\en-US\\Common\\Words\\Text1.txt");
                                        Result = streamReader.ReadToEnd();
                                        return Result;
                                    }
                                    catch (FileNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                case "Letters":
                                    try
                                    {
                                        streamReader = new StreamReader("Texts\\en-US\\Common\\Letters\\Text1.txt");
                                        Result = streamReader.ReadToEnd();
                                        return Result;
                                    }
                                    catch (FileNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                case "Numbers":
                                    try
                                    {
                                        streamReader = new StreamReader("Texts\\en-US\\Common\\Numbers\\Text1.txt");
                                        Result = streamReader.ReadToEnd();
                                        return Result;
                                    }
                                    catch (FileNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                default:
                                    return "File not found!";
                            }
                        }
                        else
                        {
                            switch (Properties.Settings.Default.Mode)
                            {
                                case "Text":
                                    try
                                    {
                                        streamReader = new StreamReader("Texts\\en-US\\Uncommon\\Text\\Text1.txt");
                                        Result = streamReader.ReadToEnd();
                                        return Result;
                                    }
                                    catch (FileNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                case "Words":
                                    try
                                    {
                                        streamReader = new StreamReader("Texts\\en-US\\Uncommon\\Words\\Text1.txt");
                                        Result = streamReader.ReadToEnd();
                                        return Result;
                                    }
                                    catch (FileNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                case "Letters":
                                    try
                                    {
                                        streamReader = new StreamReader("Texts\\en-US\\Uncommon\\Letters\\Text1.txt");
                                        Result = streamReader.ReadToEnd();
                                        return Result;
                                    }
                                    catch (FileNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                case "Numbers":
                                    try
                                    {
                                        streamReader = new StreamReader("Texts\\en-US\\Uncommon\\Numbers\\Text1.txt");
                                        Result = streamReader.ReadToEnd();
                                        return Result;
                                    }
                                    catch (FileNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                default:
                                    return "File not found!";
                            }
                        }
                    }
                    else
                    {
                        if (Properties.Settings.Default.TextDifficulty == "Common")
                        {
                            switch (Properties.Settings.Default.Mode)
                            {
                                case "Text":
                                    try
                                    {
                                        streamReader = new StreamReader("Texts\\ru\\Common\\Text\\Text1.txt");
                                        Result = streamReader.ReadToEnd();
                                        return Result;
                                    }
                                    catch (FileNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                case "Words":
                                    try
                                    {
                                        streamReader = new StreamReader("Texts\\ru\\Common\\Words\\Text1.txt");
                                        Result = streamReader.ReadToEnd();
                                        return Result;
                                    }
                                    catch (FileNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                case "Letters":
                                    try
                                    {
                                        streamReader = new StreamReader("Texts\\ru\\Common\\Letters\\Text1.txt");
                                        Result = streamReader.ReadToEnd();
                                        return Result;
                                    }
                                    catch (FileNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                case "Numbers":
                                    try
                                    {
                                        streamReader = new StreamReader("Texts\\ru\\Common\\Numbers\\Text1.txt");
                                        Result = streamReader.ReadToEnd();
                                        return Result;
                                    }
                                    catch (FileNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                default:
                                    return "File not found!";
                            }
                        }
                        else
                        {
                            switch (Properties.Settings.Default.Mode)
                            {
                                case "Text":
                                    try
                                    {
                                        streamReader = new StreamReader("Texts\\ru\\Uncommon\\Text\\Text1.txt");
                                        Result = streamReader.ReadToEnd();
                                        return Result;
                                    }
                                    catch (FileNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                case "Words":
                                    try
                                    {
                                        streamReader = new StreamReader("Texts\\ru\\Uncommon\\Words\\Text1.txt");
                                        Result = streamReader.ReadToEnd();
                                        return Result;
                                    }
                                    catch (FileNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                case "Letters":
                                    try
                                    {
                                        streamReader = new StreamReader("Texts\\ru\\Uncommon\\Letters\\Text1.txt");
                                        Result = streamReader.ReadToEnd();
                                        return Result;
                                    }
                                    catch (FileNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                case "Numbers":
                                    try
                                    {
                                        streamReader = new StreamReader("Texts\\ru\\Uncommon\\Numbers\\Text1.txt");
                                        Result = streamReader.ReadToEnd();
                                        return Result;
                                    }
                                    catch (FileNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                default:
                                    return "File not found!";
                            }
                        }
                    }
                case 2:
                    if (Properties.Settings.Default.TextLanguage == "en-US")
                    {
                        if (Properties.Settings.Default.TextDifficulty == "Common")
                        {
                            switch (Properties.Settings.Default.Mode)
                            {
                                case "Text":
                                    try
                                    {
                                        streamReader = new StreamReader("Texts\\en-US\\Common\\Text\\Text2.txt");
                                        Result = streamReader.ReadToEnd();
                                        return Result;
                                    }
                                    catch (FileNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                case "Words":
                                    try
                                    {
                                        streamReader = new StreamReader("Texts\\en-US\\Common\\Words\\Text2.txt");
                                        Result = streamReader.ReadToEnd();
                                        return Result;
                                    }
                                    catch (FileNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                case "Letters":
                                    try
                                    {
                                        streamReader = new StreamReader("Texts\\en-US\\Common\\Letters\\Text2.txt");
                                        Result = streamReader.ReadToEnd();
                                        return Result;
                                    }
                                    catch (FileNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                case "Numbers":
                                    try
                                    {
                                        streamReader = new StreamReader("Texts\\en-US\\Common\\Numbers\\Text2.txt");
                                        Result = streamReader.ReadToEnd();
                                        return Result;
                                    }
                                    catch (FileNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                default:
                                    return "File not found!";
                            }
                        }
                        else
                        {
                            switch (Properties.Settings.Default.Mode)
                            {
                                case "Text":
                                    try
                                    {
                                        streamReader = new StreamReader("Texts\\en-US\\Uncommon\\Text\\Text2.txt");
                                        Result = streamReader.ReadToEnd();
                                        return Result;
                                    }
                                    catch (FileNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                case "Words":
                                    try
                                    {
                                        streamReader = new StreamReader("Texts\\en-US\\Uncommon\\Words\\Text2.txt");
                                        Result = streamReader.ReadToEnd();
                                        return Result;
                                    }
                                    catch (FileNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                case "Letters":
                                    try
                                    {
                                        streamReader = new StreamReader("Texts\\en-US\\Uncommon\\Letters\\Text2.txt");
                                        Result = streamReader.ReadToEnd();
                                        return Result;
                                    }
                                    catch (FileNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                case "Numbers":
                                    try
                                    {
                                        streamReader = new StreamReader("Texts\\en-US\\Uncommon\\Numbers\\Text2.txt");
                                        Result = streamReader.ReadToEnd();
                                        return Result;
                                    }
                                    catch (FileNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                default:
                                    return "File not found!";
                            }
                        }
                    }
                    else
                    {
                        if (Properties.Settings.Default.TextDifficulty == "Common")
                        {
                            switch (Properties.Settings.Default.Mode)
                            {
                                case "Text":
                                    try
                                    {
                                        streamReader = new StreamReader("Texts\\ru\\Common\\Text\\Text2.txt");
                                        Result = streamReader.ReadToEnd();
                                        return Result;
                                    }
                                    catch (FileNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                case "Words":
                                    try
                                    {
                                        streamReader = new StreamReader("Texts\\ru\\Common\\Words\\Text2.txt");
                                        Result = streamReader.ReadToEnd();
                                        return Result;
                                    }
                                    catch (FileNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                case "Letters":
                                    try
                                    {
                                        streamReader = new StreamReader("Texts\\ru\\Common\\Letters\\Text2.txt");
                                        Result = streamReader.ReadToEnd();
                                        return Result;
                                    }
                                    catch (FileNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                case "Numbers":
                                    try
                                    {
                                        streamReader = new StreamReader("Texts\\ru\\Common\\Numbers\\Text2.txt");
                                        Result = streamReader.ReadToEnd();
                                        return Result;
                                    }
                                    catch (FileNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                default:
                                    return "File not found!";
                            }
                        }
                        else
                        {
                            switch (Properties.Settings.Default.Mode)
                            {
                                case "Text":
                                    try
                                    {
                                        streamReader = new StreamReader("Texts\\ru\\Uncommon\\Text\\Text2.txt");
                                        Result = streamReader.ReadToEnd();
                                        return Result;
                                    }
                                    catch (FileNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                case "Words":
                                    try
                                    {
                                        streamReader = new StreamReader("Texts\\ru\\Uncommon\\Words\\Text2.txt");
                                        Result = streamReader.ReadToEnd();
                                        return Result;
                                    }
                                    catch (FileNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                case "Letters":
                                    try
                                    {
                                        streamReader = new StreamReader("Texts\\ru\\Uncommon\\Letters\\Text2.txt");
                                        Result = streamReader.ReadToEnd();
                                        return Result;
                                    }
                                    catch (FileNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                case "Numbers":
                                    try
                                    {
                                        streamReader = new StreamReader("Texts\\ru\\Uncommon\\Numbers\\Text2.txt");
                                        Result = streamReader.ReadToEnd();
                                        return Result;
                                    }
                                    catch (FileNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                default:
                                    return "File not found!";
                            }
                        }
                    }
                default:
                    if (Properties.Settings.Default.TextLanguage == "en-US")
                    {
                        if (Properties.Settings.Default.TextDifficulty == "Common")
                        {
                            switch (Properties.Settings.Default.Mode)
                            {
                                case "Text":
                                    try
                                    {
                                        streamReader = new StreamReader("Texts\\en-US\\Common\\Text\\Text.txt");
                                        Result = streamReader.ReadToEnd();
                                        return Result;
                                    }
                                    catch (FileNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                case "Words":
                                    try
                                    {
                                        streamReader = new StreamReader("Texts\\en-US\\Common\\Words\\Text.txt");
                                        Result = streamReader.ReadToEnd();
                                        return Result;
                                    }
                                    catch (FileNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                case "Letters":
                                    try
                                    {
                                        streamReader = new StreamReader("Texts\\en-US\\Common\\Letters\\Text.txt");
                                        Result = streamReader.ReadToEnd();
                                        return Result;
                                    }
                                    catch (FileNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                case "Numbers":
                                    try
                                    {
                                        streamReader = new StreamReader("Texts\\en-US\\Common\\Numbers\\Text.txt");
                                        Result = streamReader.ReadToEnd();
                                        return Result;
                                    }
                                    catch (FileNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                default:
                                    return "File not found!";
                            }
                        }
                        else
                        {
                            switch (Properties.Settings.Default.Mode)
                            {
                                case "Text":
                                    try
                                    {
                                        streamReader = new StreamReader("Texts\\en-US\\Uncommon\\Text\\Text.txt");
                                        Result = streamReader.ReadToEnd();
                                        return Result;
                                    }
                                    catch (FileNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                case "Words":
                                    try
                                    {
                                        streamReader = new StreamReader("Texts\\en-US\\Uncommon\\Words\\Text.txt");
                                        Result = streamReader.ReadToEnd();
                                        return Result;
                                    }
                                    catch (FileNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                case "Letters":
                                    try
                                    {
                                        streamReader = new StreamReader("Texts\\en-US\\Uncommon\\Letters\\Text.txt");
                                        Result = streamReader.ReadToEnd();
                                        return Result;
                                    }
                                    catch (FileNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                case "Numbers":
                                    try
                                    {
                                        streamReader = new StreamReader("Texts\\en-US\\Uncommon\\Numbers\\Text.txt");
                                        Result = streamReader.ReadToEnd();
                                        return Result;
                                    }
                                    catch (FileNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                default:
                                    return "File not found!";
                            }
                        }
                    }
                    else
                    {
                        if (Properties.Settings.Default.TextDifficulty == "Common")
                        {
                            switch (Properties.Settings.Default.Mode)
                            {
                                case "Text":
                                    try
                                    {
                                        streamReader = new StreamReader("Texts\\ru\\Common\\Text\\Text.txt");
                                        Result = streamReader.ReadToEnd();
                                        return Result;
                                    }
                                    catch (FileNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                case "Words":
                                    try
                                    {
                                        streamReader = new StreamReader("Texts\\ru\\Common\\Words\\Text.txt");
                                        Result = streamReader.ReadToEnd();
                                        return Result;
                                    }
                                    catch (FileNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                case "Letters":
                                    try
                                    {
                                        streamReader = new StreamReader("Texts\\ru\\Common\\Letters\\Text.txt");
                                        Result = streamReader.ReadToEnd();
                                        return Result;
                                    }
                                    catch (FileNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                case "Numbers":
                                    try
                                    {
                                        streamReader = new StreamReader("Texts\\ru\\Common\\Numbers\\Text.txt");
                                        Result = streamReader.ReadToEnd();
                                        return Result;
                                    }
                                    catch (FileNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                default:
                                    return "File not found!";
                            }
                        }
                        else
                        {
                            switch (Properties.Settings.Default.Mode)
                            {
                                case "Text":
                                    try
                                    {
                                        streamReader = new StreamReader("Texts\\ru\\Uncommon\\Text\\Text.txt");
                                        Result = streamReader.ReadToEnd();
                                        return Result;
                                    }
                                    catch (FileNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                case "Words":
                                    try
                                    {
                                        streamReader = new StreamReader("Texts\\ru\\Uncommon\\Words\\Text.txt");
                                        Result = streamReader.ReadToEnd();
                                        return Result;
                                    }
                                    catch (FileNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                case "Letters":
                                    try
                                    {
                                        streamReader = new StreamReader("Texts\\ru\\Uncommon\\Letters\\Text.txt");
                                        Result = streamReader.ReadToEnd();
                                        return Result;
                                    }
                                    catch (FileNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                case "Numbers":
                                    try
                                    {
                                        streamReader = new StreamReader("Texts\\ru\\Uncommon\\Numbers\\Text.txt");
                                        Result = streamReader.ReadToEnd();
                                        return Result;
                                    }
                                    catch (FileNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        Result = ("File not found!");
                                        return Result;
                                    }
                                default:
                                    return "File not found!";
                            }
                        }
                    }
            }
        }
        public void Timer(int t)
        {
            DateTime time = DateTime.Now.AddSeconds(t);
            do
            {

            } while (DateTime.Now < time);
        }
    }
}
