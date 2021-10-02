using System;
using UnityEngine;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;WeaponEntity&gt;`. Inherits from `IPair&lt;WeaponEntity&gt;`.
    /// </summary>
    [Serializable]
    public struct WeaponEntityPair : IPair<WeaponEntity>
    {
        public WeaponEntity Item1 { get => _item1; set => _item1 = value; }
        public WeaponEntity Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private WeaponEntity _item1;
        [SerializeField]
        private WeaponEntity _item2;

        public void Deconstruct(out WeaponEntity item1, out WeaponEntity item2) { item1 = Item1; item2 = Item2; }
    }
}