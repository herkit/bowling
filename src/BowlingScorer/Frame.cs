﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BowlingScorer
{
    public class Frame
    {
        public int[] Rolls { get; set; }
        public int Score { get; set; }

        public bool IsStrike
        {
            get
            {
                return (Rolls[0] == 10);
            }
        }

        public bool IsSpare
        {
            get
            {
                return (Rolls.Sum() == 10 && Rolls[0] != 10);
            }
        }

    }
}
