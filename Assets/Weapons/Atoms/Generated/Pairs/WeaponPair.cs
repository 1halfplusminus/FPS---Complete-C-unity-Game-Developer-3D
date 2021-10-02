using System;
using UnityEngine;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;Weapon&gt;`. Inherits from `IPair&lt;Weapon&gt;`.
    /// </summary>
    [Serializable]
    public struct WeaponPair : IPair<Weapon>
    {
        public Weapon Item1 { get => _item1; set => _item1 = value; }
        public Weapon Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private Weapon _item1;
        [SerializeField]
        private Weapon _item2;

        public void Deconstruct(out Weapon item1, out Weapon item2) { item1 = Item1; item2 = Item2; }
    }
}