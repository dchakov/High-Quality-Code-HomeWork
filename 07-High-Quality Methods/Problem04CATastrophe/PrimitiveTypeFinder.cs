namespace Problem04CATastrophe
{
    using System;
    using System.Collections.Generic;

    public class PrimitiveTypeFinder
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            string[] text = new string[lines];
            for (int i = 0; i < lines; i++)
            {
                text[i] = Console.ReadLine();
            }

            List<string> primitiveTypes = new List<string>() { "sbyte", "byte", "short", "ushort", "int", "uint", "long", "ulong", "float", "double", "decimal", "bool", "char", "string" };
            List<string> primitiveTypesNull = new List<string>() { "sbyte?", "byte?", "short?", "ushort?", "int?", "uint?", "long?", "ulong?", "float?", "double?", "decimal?", "bool?", "char?", "string?" };
            List<string> methods = new List<string>();
            List<string> loops = new List<string>();
            List<string> conditional = new List<string>();

            int counter = 0;
            for (int i = 0; i < lines; i++)
            {
                if (text[i].IndexOf("if") >= 0)
                {
                    i++;
                    do
                    {
                        if (text[i].Trim() == "{")
                        {
                            counter++;
                        }

                        if (text[i].Trim() == "}")
                        {
                            counter--;
                        }

                        string[] current = text[i].Trim().Split(' ');
                        for (int j = 0; j < current.Length; j++)
                        {
                            if (primitiveTypes.Contains(current[j]))
                            {
                                conditional.Add(current[j + 1]);
                            }
                        }

                        i++;
                    } while (counter != 0);
                }

                if (text[i].IndexOf("else") >= 0)
                {
                    i++;
                    do
                    {
                        if (text[i].Trim() == "{")
                        {
                            counter++;
                        }

                        if (text[i].Trim() == "}")
                        {
                            counter--;
                        }

                        string[] current = text[i].Trim().Split(' ');
                        for (int j = 0; j < current.Length; j++)
                        {
                            if (primitiveTypes.Contains(current[j]))
                            {
                                conditional.Add(current[j + 1]);
                            }
                        }

                        i++;
                    } while (counter != 0);
                }
            }

            for (int i = 0; i < lines; i++)
            {
                if (text[i].IndexOf("for") >= 0 || text[i].IndexOf("while") >= 0 || text[i].IndexOf("foreach") >= 0)
                {
                    string[] currentL = text[i].Trim().Split(new char[] { ' ', ',', '(', ')', '=' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 0; j < currentL.Length; j++)
                    {
                        if (primitiveTypes.Contains(currentL[j]))
                        {
                            if (!conditional.Contains(currentL[j + 1]))
                            {
                                loops.Add(currentL[j + 1]);
                            }
                        }
                    }

                    i++;
                    do
                    {
                        if (text[i].Trim() == "{")
                        {
                            counter++;
                        }

                        if (text[i].Trim() == "}")
                        {
                            counter--;
                        }

                        string[] currentK = text[i].Trim().Split(new char[] { ' ', ',', '(', ')', '=' }, StringSplitOptions.RemoveEmptyEntries);
                        for (int j = 0; j < currentK.Length; j++)
                        {
                            if (primitiveTypes.Contains(currentK[j]))
                            {
                                if (!conditional.Contains(currentK[j + 1]) && char.IsLetter(currentK[j + 1].ToString()[0]))
                                {
                                    loops.Add(currentK[j + 1]);
                                }
                            }
                        }

                        i++;
                    } while (counter != 0);
                }
            }

            for (int i = 0; i < lines; i++)
            {
                if (text[i].IndexOf("static") >= 0)
                {
                    string[] current = text[i].Trim().Split(new char[] { ' ', ',', '(', ')', ';', '=' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 2; j < current.Length; j++)
                    {
                        if (primitiveTypes.Contains(current[j]) || primitiveTypesNull.Contains(current[j]))
                        {
                            if (char.IsLetter(current[j + 1].ToCharArray()[0]))
                            {
                            }
                        }
                    }

                    i++;
                    do
                    {
                        if (text[i].Trim() == "{")
                        {
                            counter++;
                        }

                        if (text[i].Trim() == "}" || text[i].Trim() == "};")
                        {
                            counter--;
                        }

                        string[] currentM = text[i].Trim().Split(new char[] { ' ', ',', '(', ')', ';', '=' }, StringSplitOptions.RemoveEmptyEntries);
                        for (int j = 0; j < currentM.Length; j++)
                        {
                            if (primitiveTypes.Contains(currentM[j]) || primitiveTypesNull.Contains(currentM[j]))
                            {
                                if (!conditional.Contains(currentM[j + 1]) && !loops.Contains(currentM[j + 1]) && char.IsLetter(currentM[j + 1].ToCharArray()[0]))
                                {
                                    methods.Add(currentM[j + 1]);
                                }
                            }
                        }

                        i++;
                    } while (counter != 0);
                }
            }

            Console.Write("Methods -> ");
            Console.WriteLine(methods.Count > 0 ? methods.Count + " -> " + string.Join(", ", methods.ToArray()) : "None");
            Console.Write("Loops -> ");
            Console.WriteLine(loops.Count > 0 ? loops.Count + " -> " + string.Join(", ", loops.ToArray()) : "None");
            Console.Write("Conditional Statements -> ");
            Console.WriteLine(conditional.Count > 0 ? conditional.Count + " -> " + string.Join(", ", conditional.ToArray()) : "None");
        }
    }
}