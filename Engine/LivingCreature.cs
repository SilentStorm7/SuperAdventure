﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class LivingCreature
    {
        public int MaximumHitPoints { get; set; }
        public int CurrentHitPoints { get; set; }

        public LivingCreature(int maximumHitPoints, int currentHitPoints) {
            MaximumHitPoints = maximumHitPoints;
            CurrentHitPoints = currentHitPoints;
        }
    }
}
