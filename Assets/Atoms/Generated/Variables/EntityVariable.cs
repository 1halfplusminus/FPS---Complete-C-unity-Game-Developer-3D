using UnityEngine;
using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `Entity`. Inherits from `AtomVariable&lt;Entity, EntityPair, EntityEvent, EntityPairEvent, EntityEntityFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Entity", fileName = "EntityVariable")]
    public sealed class EntityVariable : AtomVariable<Entity, EntityPair, EntityEvent, EntityPairEvent, EntityEntityFunction>
    {
        protected override bool ValueEquals(Entity other)
        {
            return other.Id == Value.Id;
        }
    }
}
