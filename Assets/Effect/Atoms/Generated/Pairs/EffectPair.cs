using System;
using UnityEngine;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;Effect&gt;`. Inherits from `IPair&lt;Effect&gt;`.
    /// </summary>
    [Serializable]
    public struct EffectPair : IPair<Effect>
    {
        public Effect Item1 { get => _item1; set => _item1 = value; }
        public Effect Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private Effect _item1;
        [SerializeField]
        private Effect _item2;

        public void Deconstruct(out Effect item1, out Effect item2) { item1 = Item1; item2 = Item2; }
    }
}