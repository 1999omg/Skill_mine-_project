using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skill_mine__project.String
{
    class Split
    {
        // 1.	WAP to split string into 2 tokens where string is “HELLO$WORLD”

        public void spiltstring ()
        {
            string s = "hello$World";
            char[] ch = s.ToCharArray();
            char space =' ';
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == '$')
                {
                    ch[i] = space;
                }
            }
            foreach(char c in ch)
            {
                Console.WriteLine(c);
            }
        }


        
    }
}