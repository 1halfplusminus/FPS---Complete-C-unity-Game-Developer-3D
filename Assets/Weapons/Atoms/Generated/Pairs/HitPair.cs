using System;
using UnityEngine;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;Hit&gt;`. Inherits from `IPair&lt;Hit&gt;`.
    /// </summary>
    [Serializable]
    public struct HitPair : IPair<Hit>
    {
        public Hit Item1 { get => _item1; set => _item1 = value; }
        public Hit Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private Hit _item1;
        [SerializeField]
        private Hit _item2;

        public void Deconstruct(out Hit item1, out Hit item2) { item1 = Item1; item2 = Item2; }
    }
}