using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestWord
{
    public class Methods
    {
        public int CountSimbInLine(string a)
        {
            return a.Length;
        }

        public int CountWordsInLine(string a)
        {
            string[] words = a.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int wordCount = words.Length;
            return  wordCount;
        }

        public string Find9SimbInLine(string a)
        {
            
            return Convert.ToString(a[8]);
        }

        public int FindAMInLine(string a, string comb)
        {
            // Создаем регулярное выражение для поиска комбинаций символов
            string pattern = $"[{comb}][{comb}]";

            // Подсчитываем количество комбинаций
            int count = Regex.Matches(a, pattern).Count;

            return count;
        }

        public int FindNumsInLine(string a)
        {
            int count = 0;

            foreach (char c in a)
            {
                if (char.IsDigit(c))
                {
                    count++;
                }
            }

            return count;
        }

        public int FindRowNumsInLine(string a)
        {
            int maxCount = 0;
            int count = 0;

            foreach (char c in a)
            {
                if (char.IsDigit(c))
                {
                    count++;
                    maxCount = Math.Max(count, maxCount);
                }
                else
                {
                    count = 0;
                }
            }

            return maxCount;
        }

        public string MostShortlyWorldInTheLine(string a)
        {
            string[] words = a.Split(' ');

            var sortedWords = words.OrderBy(word => word.Length);

            string output = string.Join(" ", sortedWords);
            return output;
        }
    }
}
