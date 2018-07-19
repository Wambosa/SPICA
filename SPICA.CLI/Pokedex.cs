﻿using System;

using SPICA.Formats.CtrH3D;
using System.Collections.Generic;
using System.Text;

namespace SPICA.CLI
{
    class Pokedex
    {
        public static Dictionary<string, string> StandardMotion = new Dictionary<string, string>() {
            { "idle", "Motion_0"},
            { "attack-close", "Motion_6"},
            { "attack-range", "Motion_9"},
            { "hit", "Motion_13"},
            { "faint", "Motion_17"},
            { "celebrate", "Motion_10_1"},
            { "walk", "Motion_1_2"},
            { "run", "Motion_3_2"},
        };
    }
}
