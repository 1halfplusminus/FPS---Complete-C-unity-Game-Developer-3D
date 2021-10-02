using System;
using UnityEngine;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;HealthCreated&gt;`. Inherits from `IPair&lt;HealthCreated&gt;`.
    /// </summary>
    [Serializable]
    public struct HealthCreatedPair : IPair<HealthCreated>
    {
        public HealthCreated Item1 { get => _item1; set => _item1 = value; }
        public HealthCreated Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private HealthCreated _item1;
        [SerializeField]
        private HealthCreated _item2;

        public void Deconstruct(out HealthCreated item1, out HealthCreated item2) { item1 = Item1; item2 = Item2; }
    }
}