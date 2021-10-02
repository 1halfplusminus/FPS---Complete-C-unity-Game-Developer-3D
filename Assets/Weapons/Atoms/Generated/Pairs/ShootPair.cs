using System;
using UnityEngine;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;Shoot&gt;`. Inherits from `IPair&lt;Shoot&gt;`.
    /// </summary>
    [Serializable]
    public struct ShootPair : IPair<Shoot>
    {
        public Shoot Item1 { get => _item1; set => _item1 = value; }
        public Shoot Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private Shoot _item1;
        [SerializeField]
        private Shoot _item2;

        public void Deconstruct(out Shoot item1, out Shoot item2) { item1 = Item1; item2 = Item2; }
    }
}