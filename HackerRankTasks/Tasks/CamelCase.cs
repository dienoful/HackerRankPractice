﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HackerRankTasks.Tasks
{
    /*
        There is a sequence of words in CamelCase as a string of letters, s, having the following properties:
        - It is a concatenation of one or more words consisting of English letters.
        - All letters in the first word are lowercase.
        - For each of the subsequent words, the first letter is uppercase and rest of the letters are lowercase.
        Given s, determine the number of words in s.
     */
    internal class CamelCase
    {
        public static int SolveProblem(string s)
        {
            return Regex.Matches(s, "[A-Z]").Count + 1;
        }
    }
}
