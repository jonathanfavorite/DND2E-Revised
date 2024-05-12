namespace DND2E.CORE.Models.AbilityScores
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AbilityAttribute
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public AbilityAttribute()
        {

        }
        public AbilityAttribute(string name, int value)
        {
            Name = name;
            Value = value;
        }
        public override string ToString()
        {
            return $"{Name}: {Value}";
        }
    }
}
