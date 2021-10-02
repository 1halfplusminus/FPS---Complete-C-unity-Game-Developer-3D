using UnityEngine;
using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `Effect`. Inherits from `AtomVariable&lt;Effect, EffectPair, EffectEvent, EffectPairEvent, EffectEffectFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Effect", fileName = "EffectVariable")]
    public sealed class EffectVariable : AtomVariable<Effect, EffectPair, EffectEvent, EffectPairEvent, EffectEffectFunction>
    {
        protected override bool ValueEquals(Effect other)
        {
            throw new NotImplementedException();
        }
    }
}
