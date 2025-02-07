using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Task4___StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine("Current Directory: " + currentDirectory);

            string filePath = "file.md";

            try
            {
                string fileContent = File.ReadAllText(filePath);
                StringBuilder html = new StringBuilder();
                string[] lines = fileContent.Split(new[] { '\n' });
                bool notInCodingBlock = true;

                foreach (string line in lines)
                {
                    string trimmedLine = line.Trim();

                    if (trimmedLine.StartsWith("```"))
                    {
                        if (notInCodingBlock)
                        {
                            html.Append("<pre><code>\n");
                        }
                        else
                        {
                            html.Append("</code></pre>\n");
                        }
                        notInCodingBlock = !notInCodingBlock;
                        continue;
                    }
                    if (!notInCodingBlock)
                    {
                        html.Append(System.Net.WebUtility.HtmlEncode(line) + "\n");
                        continue;
                    }

                    Match headingMatch = Regex.Match(trimmedLine, "^(#{1,6})\\s+(.+)");
                    if (headingMatch.Success)
                    {
                        int level = headingMatch.Groups[1].Length;
                        string content = headingMatch.Groups[2].Value;
                        html.AppendFormat("<h{0}>{1}</h{0}>\n", level, content);
                        continue;
                    }

                    if (trimmedLine.StartsWith(">"))
                    {
                        html.AppendFormat("<blockquote>{0}</blockquote>\n", trimmedLine.Substring(1).Trim());
                        continue;
                    }

                    if (Regex.IsMatch(trimmedLine, "^(-{3,}|_{3,}|\\*{3,})$"))
                    {
                        html.Append("<hr>\n");
                        continue;
                    }

                    string newLine = trimmedLine;
                    newLine = Regex.Replace(newLine, "\\*\\*(.*?)\\*\\*", "<strong>$1</strong>");
                    newLine = Regex.Replace(newLine, "\\*(.*?)\\*", "<em>$1</em>");
                    newLine = Regex.Replace(newLine, "`(.*?)`", "<code>$1</code>");
                    newLine = Regex.Replace(newLine, "!\\[(.*?)\\]\\((.*?)\\)", "<img src=\"$2\" alt=\"$1\">");
                    newLine = Regex.Replace(newLine, "\\[(.*?)\\]\\((.*?)\\)", "<a href=\"$2\">$1</a>");

                    if (!string.IsNullOrWhiteSpace(newLine))
                    {
                        html.AppendFormat("<p>{0}</p>\n", newLine);
                    }
                }
                Console.WriteLine(html);
                Console.ReadKey();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
