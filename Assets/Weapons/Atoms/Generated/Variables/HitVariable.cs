using UnityEngine;
using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `Hit`. Inherits from `AtomVariable&lt;Hit, HitPair, HitEvent, HitPairEvent, HitHitFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Hit", fileName = "HitVariable")]
    public sealed class HitVariable : AtomVariable<Hit, HitPair, HitEvent, HitPairEvent, HitHitFunction>
    {
        protected override bool ValueEquals(Hit other)
        {
            throw new NotImplementedException();
        }
    }
}
