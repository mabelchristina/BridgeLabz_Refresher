﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefresherPrograms
{
    internal class CharactersPresent
    {
        public void Present(string str) 
        {
            if(str.Contains('a') && str.Contains('e') && str.Contains('p'))
            {
                Console.WriteLine("All Present");
            }
            else if(str.Contains('a') || str.Contains('e') || str.Contains('p'))
            {
                Console.WriteLine("One or more - Present");
            }
            else
            {
                Console.WriteLine("None Present");
            }
        }
    }
}
