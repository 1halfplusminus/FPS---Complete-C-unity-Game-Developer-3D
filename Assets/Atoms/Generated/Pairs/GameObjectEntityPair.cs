using System;
using UnityEngine;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;GameObjectEntity&gt;`. Inherits from `IPair&lt;GameObjectEntity&gt;`.
    /// </summary>
    [Serializable]
    public struct GameObjectEntityPair : IPair<GameObjectEntity>
    {
        public GameObjectEntity Item1 { get => _item1; set => _item1 = value; }
        public GameObjectEntity Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private GameObjectEntity _item1;
        [SerializeField]
        private GameObjectEntity _item2;

        public void Deconstruct(out GameObjectEntity item1, out GameObjectEntity item2) { item1 = Item1; item2 = Item2; }
    }
}