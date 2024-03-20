using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Verse;

namespace CosRimAir
{
    public class CosRimAirSettings : ModSettings
    {
        public bool verboseLogging = false;

        public float powerOutput = 1000f;

        public IntRange rainfallRange = new IntRange(500, 1800);

        public IntRange temperatureRange = new IntRange(12, 32);

        public Dictionary<string, bool> excludedBiomes = new Dictionary<string, bool>();

        public override void ExposeData()
        {
            base.ExposeData();
            Scribe_Values.Look(ref rainfallRange, "rainfallRange", new IntRange(500, 1800));
            Scribe_Values.Look(ref temperatureRange, "temperatureRange", new IntRange(12, 32));
            Scribe_Collections.Look(ref excludedBiomes, "excludedBiomes");
        }
    }
}
