using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skill_mine__project.String
{
    class Accurance
    {
        public void FirstString()
        {
            //2.	Write a C# program to find first occurrence of a character in a given string.

            string[] sr = { "Hello World " };
            int count = 0;
            for (int i = 0; i < sr.Length; i++)
            {
                count = 0;
                for (int j = 0; j < sr.Length; j++)
                {
                    if (sr[i] == sr[j])
                    {
                        count++;
                    }
                    if (count > 1)
                    {
                        Console.WriteLine(sr[i]);
                        break;
                    }
                }

            }
        }

        public void accurance()
        {
            string sr = "my name is om gawade";

            char[] ch = sr.ToCharArray();
            int count = 0;

            for (int i = 0; i < ch.Length; i++)
            {
                count = 0;

                for (int j = 0; j < ch.Length; j++)
                {
                    if (ch[i] == ch[j])
                    {
                        count++;
                        // ch[i] = 'z';

                    }
                }

                Console.WriteLine(ch[i] + "  reaprat times  :" + count);

            }
        }

        public void countWord()
        {
            string s = "hello friend my name is om gawade";
            char[] ch = s.ToCharArray();
            int count = 0;
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i]==' ')
                {
                    count++;
                }
            }
            Console.WriteLine(" total word in string "+(count+1));
        }
        

      //  6.	Write a C# program to remove all occurrences of a character from string.

    }
}
