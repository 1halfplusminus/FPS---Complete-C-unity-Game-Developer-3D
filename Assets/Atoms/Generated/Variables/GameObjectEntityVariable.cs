using UnityEngine;
using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `GameObjectEntity`. Inherits from `AtomVariable&lt;GameObjectEntity, GameObjectEntityPair, GameObjectEntityEvent, GameObjectEntityPairEvent, GameObjectEntityGameObjectEntityFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/GameObjectEntity", fileName = "GameObjectEntityVariable")]
    public sealed class GameObjectEntityVariable : AtomVariable<GameObjectEntity, GameObjectEntityPair, GameObjectEntityEvent, GameObjectEntityPairEvent, GameObjectEntityGameObjectEntityFunction>
    {
        protected override bool ValueEquals(GameObjectEntity other)
        {
            throw new NotImplementedException();
        }
    }
}
