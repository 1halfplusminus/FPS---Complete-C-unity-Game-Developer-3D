using System;
using UnityEngine;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;AmmoSlot&gt;`. Inherits from `IPair&lt;AmmoSlot&gt;`.
    /// </summary>
    [Serializable]
    public struct AmmoSlotPair : IPair<AmmoSlot>
    {
        public AmmoSlot Item1 { get => _item1; set => _item1 = value; }
        public AmmoSlot Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private AmmoSlot _item1;
        [SerializeField]
        private AmmoSlot _item2;

        public void Deconstruct(out AmmoSlot item1, out AmmoSlot item2) { item1 = Item1; item2 = Item2; }
    }
}