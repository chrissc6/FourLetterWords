using System;
using System.Collections.Generic;
using System.Text;

namespace FourLetterWords
{
    class UserSolution
    {
        public int four_letter_words(string s)
        {
            string ss = s;
            int x = 0;
            int y = 0;
            string ns;
            string ns2;
            string checks = " ";
            bool check = true;

            while (check)
            {
                int fx = 0;
                x = ss.IndexOf(" ");
                if(x > 0)
                {
                    ns = ss.Substring(0, x);
                    x = x + 1;
                    ns2 = ss.Substring(x);
                    x = ns.Length;
                    if (x == 4)
                    {
                        y++;
                    }
                    ss = ns2;
                    check = ss.Contains(checks);
                    if (fx > 0)
                    {
                        break;
                    }
                    else
                    {
                        if (!check)
                        {
                            fx++;
                        }
                        check = true;
                        continue;
                    }
                }
                else
                {
                    x = ss.Length;
                    if (x == 4)
                    {
                        y++;
                    }
                    break;
                }
            }

            return y;
        }
    }
}
