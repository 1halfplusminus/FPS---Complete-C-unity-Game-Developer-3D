using UnityEngine;
using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `AmmoSlot`. Inherits from `AtomVariable&lt;AmmoSlot, AmmoSlotPair, AmmoSlotEvent, AmmoSlotPairEvent, AmmoSlotAmmoSlotFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/AmmoSlot", fileName = "AmmoSlotVariable")]
    public sealed class AmmoSlotVariable : AtomVariable<AmmoSlot, AmmoSlotPair, AmmoSlotEvent, AmmoSlotPairEvent, AmmoSlotAmmoSlotFunction>
    {
        protected override bool ValueEquals(AmmoSlot other)
        {
            throw new NotImplementedException();
        }
    }
}
