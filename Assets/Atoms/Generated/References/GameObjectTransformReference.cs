using System;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Reference of type `GameObjectTransform`. Inherits from `AtomReference&lt;GameObjectTransform, GameObjectTransformPair, GameObjectTransformConstant, GameObjectTransformVariable, GameObjectTransformEvent, GameObjectTransformPairEvent, GameObjectTransformGameObjectTransformFunction, GameObjectTransformVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class GameObjectTransformReference : AtomReference<
        GameObjectTransform,
        GameObjectTransformPair,
        GameObjectTransformConstant,
        GameObjectTransformVariable,
        GameObjectTransformEvent,
        GameObjectTransformPairEvent,
        GameObjectTransformGameObjectTransformFunction,
        GameObjectTransformVariableInstancer>, IEquatable<GameObjectTransformReference>
    {
        public GameObjectTransformReference() : base() { }
        public GameObjectTransformReference(GameObjectTransform value) : base(value) { }
        public bool Equals(GameObjectTransformReference other) { return base.Equals(other); }
        protected override bool ValueEquals(GameObjectTransform other)
        {
            throw new NotImplementedException();
        }
    }
}
