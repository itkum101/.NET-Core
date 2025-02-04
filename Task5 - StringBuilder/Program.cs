using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

namespace Task4___StringBuilder
{
    internal class Program
    {
        //REGEX RULE NEEDED 
        static void Main(string[] args)
        {

            // Check and display the current working directory
            string currentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine("Current Directory: " + currentDirectory);

            string filePath = "file.md"; // Goes up two directories

            try
            {
                //Reading all contents from file.md
                string fileContent = File.ReadAllText(filePath);

                StringBuilder html = new StringBuilder();

                //Now Splitting the files when this character is encountered \n. Now lines are divided into array of string
                string[] lines = fileContent.Split(new[] { '\n' });

                bool notInCodingBlock = true;



                foreach (string line in lines)
                {
                    //Now trimming extra white spaces and tabs.
                    string trimmedLine = line.Trim();//This will trim in the start and at the end too.

                    //Code Block

                    if (trimmedLine.StartsWith("```"))
                    {

                        if (notInCodingBlock)
                        {
                            html.Append("<code><pre>\n");
                        }
                        else
                        {
                            html.Append("</pre></code>\n");

                        }
                        notInCodingBlock = !notInCodingBlock;
                        continue; //Go to next iterations

                    }
                    //While notInCodingBlock is false add the code in html as it is.
                    if (!notInCodingBlock)
                    {
                        html.Append(line + '\n');
                        continue; // Go to next iterations
                    }

                    //Heading
                    Match headingMatch = Regex.Match(trimmedLine, @"^(#{1,6})\s+(.+)");
                    if (headingMatch.Success)
                    {
                        int level = headingMatch.Groups[1].Length; // Count of '#' determines heading level
                        string content = headingMatch.Groups[2].Value; // Extracted heading text
                        html.AppendFormat("<h{0}>{1}</h{0}>\n", level, content);
                        continue;
                    }

                    // Blockquotes(>) simple case, it won't work for nested one.
                    if (trimmedLine.StartsWith(">"))
                    {
                        html.AppendFormat("<blockquote>{0}</blockquote>\n", trimmedLine.Substring(1).Trim());
                        continue;
                    }

                    //Horizontal Lines
                    // Handle Horizontal Rules (---, ***, ___)
                    if (Regex.IsMatch(trimmedLine, @"^(-{3,}|_{3,}|\*{3,})$"))
                    {
                        html.Append("<hr>\n");
                        continue;
                    }


                    //(. * + ? | () [] {})
                    //These characters have special meaning so \ is used to escape the actual use of this character.

                    string newLine = trimmedLine;
                    // * is a special character so \* is used , (.*?) is used to store
                    //Bold **Some Text**
                    newLine = Regex.Replace(newLine, @"\*\*(.*?)\*\*", "<strong>$1</strong>");

                    //Italic *Some Text*
                    newLine = Regex.Replace(newLine, @"\*(.*?)\*", "<em>$1</em>");

                    // Inline Code
                    //To denote a word or phrase as code, enclose it in backticks (`).
                    newLine = Regex.Replace(newLine, @"`(.*?)`", "<code>$1</code>");

                    //![alt](url)
                    newLine = Regex.Replace(newLine, @"!\[(.*?)\]\((.*?)\)", "<img src=\"$2\" alt=\"$1\">");

                    // [text](url)
                    newLine = Regex.Replace(newLine, @"\[(.*?)\]\((.*?)\)", "<a href=\"$2\">$1</a>");


                    // Handle Paragraphs
                    if (!string.IsNullOrWhiteSpace(newLine))
                    {
                        html.AppendFormat("<p>{0}</p>\n", newLine);
                    }



                }
                Console.WriteLine(html);


                //Console.WriteLine(fileContent);
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
