using System;
using UnityEngine;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;GameObjectTransform&gt;`. Inherits from `IPair&lt;GameObjectTransform&gt;`.
    /// </summary>
    [Serializable]
    public struct GameObjectTransformPair : IPair<GameObjectTransform>
    {
        public GameObjectTransform Item1 { get => _item1; set => _item1 = value; }
        public GameObjectTransform Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private GameObjectTransform _item1;
        [SerializeField]
        private GameObjectTransform _item2;

        public void Deconstruct(out GameObjectTransform item1, out GameObjectTransform item2) { item1 = Item1; item2 = Item2; }
    }
}