﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ConsoleApp
{
    static class ConsoleIO
    {
        public static void WriteLine(string s)
        {
            Console.WriteLine(s);
        }

        public static void WriteLine(object o)
        {
            Console.WriteLine(o);
        }

        public static void Write(string s)
        {
            Console.Write(s);
        }

        public static void Write(object o)
        {
            Console.Write(o);
        }

        public static void WriteCollection(params string[] collection)
        {
            WriteCollection((IEnumerable<string>)collection);
        }

        public static void WriteCollection<T>(params T[] collection)
        {
            WriteCollection((IEnumerable<T>)collection);
        }

        public static void WriteCollection(IEnumerable<string> collection)
        {
            WriteCollection(collection, Environment.NewLine);
        }

        public static void WriteCollection(IEnumerable<string> collection, string delimiter)
        {
            WriteLine(string.Join(delimiter, collection));
        }

        public static void WriteCollection<T>(IEnumerable<T> collection)
        {
            WriteCollection(collection.Select(o => o.ToString()));
        }

        public static void WriteCollection<T>(IEnumerable<T> collection, string delimiter)
        {
            WriteCollection(collection.Select(o => o.ToString()), delimiter);
        }

        public static string GetString()
        {
            return Console.ReadLine();
        }

        public static void Clear()
        {
            Console.Clear();
        }

        public static void WaitForKeyPress()
        {
            Console.ReadKey(true);
        }

        public static string GetString(string message)
        {
            message = FormatMessage(message);

            Write(message);
            return GetString();
        }

        public static int GetInt(string message = null)
        {
            return Get(int.Parse, message);
        }

        public static long GetLong(string message = null)
        {
            return Get(long.Parse, message);
        }

        public static decimal GetDecimal(string message = null)
        {
            return Get(decimal.Parse, message);
        }

        public static DateTime GetDateTime(string message = null)
        {
            return Get(DateTime.Parse, message);
        }

        public static T Get<T>(Func<string, T> converter, string message = null)
        {
            if (converter == null)
            {
                throw new ArgumentNullException(nameof(converter));
            }

            message = FormatMessage(message);

            T returnValue = default(T);

            {
                bool conversionWorked;
                do
                {
                    if (message != null)
                    {
                        Clear();

                        Write(message);
                    }

                    var valueEntered = GetString();

                    try
                    {
                        returnValue = converter(valueEntered);

                        conversionWorked = true;
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex);

                        conversionWorked = false;
                    }
                } while (!conversionWorked);
            }

            return returnValue;
        }

        public static bool YesNo(string question)
        {
            ConsoleKeyInfo keyInfo;

            {
                do
                {
                    Console.WriteLine(question + " (y/n): ");

                    keyInfo = Console.ReadKey(true);

                } while (keyInfo.Key != ConsoleKey.Y && keyInfo.Key != ConsoleKey.N);
            }

            WriteLine(keyInfo.KeyChar);

            return keyInfo.Key == ConsoleKey.Y;
        }

        public static bool? YesNoCancel(string question)
        {
            ConsoleKeyInfo keyInfo;

            {
                do
                {
                    Console.WriteLine(question + " (y/n/escape): ");

                    keyInfo = Console.ReadKey(true);

                } while (keyInfo.Key != ConsoleKey.Y && keyInfo.Key != ConsoleKey.N &&
                         keyInfo.Key != ConsoleKey.Escape);
            }

            if (keyInfo.Key == ConsoleKey.Escape)
            {
                WriteLine("Cancelled");
                return null;
            }

            WriteLine(keyInfo.KeyChar);

            return keyInfo.Key == ConsoleKey.Y;
        }

        private static string FormatMessage(string message)
        {
            if (!string.IsNullOrEmpty(message))
            {
                message.Trim();

                if (message.EndsWith(":"))
                {
                    message += " ";
                }
                else
                {
                    message += ": ";
                }
            }

            return message;
        }
    }
}
