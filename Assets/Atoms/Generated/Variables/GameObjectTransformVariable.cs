using UnityEngine;
using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `GameObjectTransform`. Inherits from `AtomVariable&lt;GameObjectTransform, GameObjectTransformPair, GameObjectTransformEvent, GameObjectTransformPairEvent, GameObjectTransformGameObjectTransformFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/GameObjectTransform", fileName = "GameObjectTransformVariable")]
    public sealed class GameObjectTransformVariable : AtomVariable<GameObjectTransform, GameObjectTransformPair, GameObjectTransformEvent, GameObjectTransformPairEvent, GameObjectTransformGameObjectTransformFunction>
    {
        protected override bool ValueEquals(GameObjectTransform other)
        {
            throw new NotImplementedException();
        }
    }
}
