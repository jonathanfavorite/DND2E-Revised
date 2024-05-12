﻿namespace DND2E.CORE.Models.AbilityScores
{
    using DND2E.CORE.Enums;
    using DND2E.CORE.Interfaces.AbilityScores;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ConstitutionAB : IConstitutionAB
    {
        public AbilityScoreTypes Type { get; set; } = AbilityScoreTypes.CONSTITUTION;
        public int Value { get; set; } = 10;
        public List<AbilityAttribute> Attributes { get; set; } = new List<AbilityAttribute>();
        public void SetAttributes(List<AbilityAttribute> attributes)
        {
            Attributes = attributes;
        }
        public override string ToString()
        {
            return $"{Value}";
        }
    }
}
