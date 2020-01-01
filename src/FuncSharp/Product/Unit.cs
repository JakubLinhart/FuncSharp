﻿
namespace FuncSharp
{
    /// <summary>
    /// The Unit type (product of zero types). It has only one instance.
    /// </summary>
    public sealed class Unit : Product0
    {
        static Unit()
        {
            Value = new Unit();
        }

        private Unit()
        {
        }

        /// <summary>
        /// The only instance of the Unit type.
        /// </summary>
        public static Unit Value { get; }

        public override int GetHashCode()
        {
            return 42;
        }
        public override bool Equals(object obj)
        {
            return this == obj;
        }
        public override string ToString()
        {
            return "()";
        }
    }
}
