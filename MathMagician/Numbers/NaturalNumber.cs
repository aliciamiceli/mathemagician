﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class NaturalNumber : Integer
    {

        public int First { get; set;  }
        public int Step { get; set; }

        public NaturalNumber()
        {
            First = 1;
            //this.First = 1;
            Step = 1;

        }

        public int GetFirst()
        {
            return First;
        }

        public int GetNext(int current)
        {
 
            return current + Step;
        }

        public int[] GetSequence(int how_many)
        {
            int[] numbers = new int[how_many];
            numbers[0] = GetFirst(); // i = 1
            for (int i = 1; i < numbers.Length; i++)
            {
                numbers[i] = GetNext(numbers[i - 1]);
            }

            return numbers;

        }

        public string printNumbers(int[] number_array)
        {
            return String.Join(" ", number_array);
        }
    }
}
