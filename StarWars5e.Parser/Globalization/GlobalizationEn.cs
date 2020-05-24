﻿using System.Collections.Generic;
using StarWars5e.Models.Enums;
using System.Collections.Generic;

namespace StarWars5e.Parser.Globalization
{
    public class GlobalizationEn : IGlobalization
    {
        public Language Language => Language.En;

        public List<(string name, string startLine, int occurence)> WretchedHivesWeaponProperties => new List<(string name, string startLine, int occurence)>
        {
            ("Auto", "#### Auto", 1),
            ("Defensive", "#### Defensive", 1),
            ("Dire", "#### Dire", 1),
            ("Disarming", "#### Disarming", 1),
            ("Disguised", "#### Disguised", 1),
            ("Disintegrate", "#### Disintegrate", 1),
            ("Disruptive", "#### Disruptive", 1),
            ("Keen", "#### Keen", 1),
            ("Mighty", "#### Mighty", 1),
            ("Piercing", "#### Piercing", 1),
            ("Rapid", "#### Rapid", 1),
            ("Shocking", "#### Shocking", 1),
            ("Silent", "#### Silent", 2),
            ("Vicious", "#### Vicious", 1)
        };

        public List<(string name, string startLine, int occurence)> WretchedHivesArmorProperties = new List<(string name, string startLine, int occurence)>
        {
            ("Absorptive", "#### Absorptive", 1),
            ("Agile", "#### Agile", 1),
            ("Anchor", "#### Anchor", 1),
            ("Avoidant", "#### Avoidant", 1),
            ("Barbed", "#### Barbed", 1),
            ("Charging", "#### Charging", 1),
            ("Concealing", "#### Concealing", 1),
            ("Cumbersome", "#### Cumbersome", 1),
            ("Gauntleted", "#### Gauntleted", 1),
            ("Imbalanced", "#### Imbalanced", 1),
            ("Impermeable", "#### Impermeable", 1),
            ("Insulated", "#### Insulated", 1),
            ("Interlocking", "#### Interlocking", 1),
            ("Lambent", "#### Lambent", 1),
            ("Lightweight", "#### Lightweight", 1),
            ("Magnetic", "#### Magnetic", 1),
            ("Obscured", "#### Obscured", 1),
            ("Powered", "#### Powered", 1),
            ("Regulated", "#### Regulated", 1),
            ("Reinforced", "#### Reinforced", 1),
            ("Responsive", "#### Responsive", 1),
            ("Rigid", "#### Rigid", 1),
            ("Silent", "#### Silent", 1),
            ("Spiked", "#### Spiked", 1),
            ("Steadfast", "#### Steadfast", 1),
            ("Versatile", "#### Versatile", 1)
        };

        public List<(string name, string startLine, int occurence)> PlayerHandbookWeaponProperties => new List<(string name, string startLine, int occurence)>
        {
            ("Ammunition", "#### Ammunition", 1),
            ("Burst", "#### Burst", 1),
            ("Dexterity", "#### Dexterity", 1),
            ("Double", "#### Double", 1),
            ("Finesse", "#### Finesse", 1),
            ("Fixed", "#### Fixed", 1),
            ("Heavy", "#### Heavy", 3 ),
            ("Hidden", "#### Hidden", 1),
            ("Light", "#### Light", 2),
            ("Luminous", "#### Luminous", 1),
            ("Range", "#### Range", 1),
            ("Reach", "#### Reach", 1),
            ("Reload", "#### Reload", 1),
            ("Returning", "#### Returning", 1),
            ("Special", "#### Special", 1),
            ("Strength", "#### Strength", 2),
            ("Thrown", "#### Thrown", 1),
            ("Two-Handed", "#### Two-Handed", 1),
            ("Versatile", "#### Versatile", 1)
        };

        public List<(string name, string startLine, int occurence)> PlayerHandbookArmorProperties => new List<(string name, string startLine, int occurence)>
        {
            ("Bulky", "#### Bulky", 1),
            ("Obtrusive", "#### Obtrusive", 1),
            ("Strength", "#### Strength", 1)
        };
    }
}