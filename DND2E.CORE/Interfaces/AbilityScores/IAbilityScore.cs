﻿namespace DND2E.CORE.Interfaces.AbilityScores
{
    using DND2E.CORE.Enums;
    using DND2E.CORE.Models.AbilityScores;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IAbilityScore
    {
        AbilityScoreTypes Type { get; set; }
        int Value { get; set; }
        List<AbilityAttribute> Attributes { get; set; }
        void SetAttributes(List<AbilityAttribute> attributes);
    }
}
