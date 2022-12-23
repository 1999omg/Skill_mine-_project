using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skill_mine__project
{
    class ClassTask
    {
        static void MMain (string[] args)
        {
            string s = "skill mine @2222";
            char[] ch = s.ToArray();
            int sum = 0;
            int count = 0;   
            for (int i = 0; i < ch.Length; i++)
            {
                int num = 0;
                if (ch[i] >= '0' && ch[i] <= '9')
                {
                    num = (int)Char.GetNumericValue(ch[i]);
                     int n =  int.Parse(ch[i].ToString());
                    

                    sum = sum + n ;
                         
                        count++;
                    }
                }
                int average = sum / count;
                Console.WriteLine(" average of number from given string is :"+ average);
            }
        

    }

       
        
            
    }

