using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skill_mine__project.String
{
    class Remove
    {
        public void remove()
        {
            //  6.Write a C# program to remove all occurrences of a character from string.
            string[] s = { "hello world " };

            for (int i = 0; i < s.Length; i++)
            {
                 for (int j = 0; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        s[i] = "";
                    }
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }
        }
    }
}
