using System;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Reference of type `GameObjectEntity`. Inherits from `AtomReference&lt;GameObjectEntity, GameObjectEntityPair, GameObjectEntityConstant, GameObjectEntityVariable, GameObjectEntityEvent, GameObjectEntityPairEvent, GameObjectEntityGameObjectEntityFunction, GameObjectEntityVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class GameObjectEntityReference : AtomReference<
        GameObjectEntity,
        GameObjectEntityPair,
        GameObjectEntityConstant,
        GameObjectEntityVariable,
        GameObjectEntityEvent,
        GameObjectEntityPairEvent,
        GameObjectEntityGameObjectEntityFunction,
        GameObjectEntityVariableInstancer>, IEquatable<GameObjectEntityReference>
    {
        public GameObjectEntityReference() : base() { }
        public GameObjectEntityReference(GameObjectEntity value) : base(value) { }
        public bool Equals(GameObjectEntityReference other) { return base.Equals(other); }
        protected override bool ValueEquals(GameObjectEntity other)
        {
            throw new NotImplementedException();
        }
    }
}
