namespace DND2E.Builders
{
    using DND2E.CORE.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Linq;

    public abstract class CharacterBuilder
    {
        protected ICharacter _character;
        public CharacterBuilder WithName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be null or whitespace.", nameof(name));
            }
            _character.Name = name;
            return this;
        }
        public CharacterBuilder WithLevel(int level)
        {
            if (level <= 0)
            {
                throw new ArgumentException("Level must be greater than 0.", nameof(level));
            }
            _character.Level = level;
            return this;
        }

    }
}
