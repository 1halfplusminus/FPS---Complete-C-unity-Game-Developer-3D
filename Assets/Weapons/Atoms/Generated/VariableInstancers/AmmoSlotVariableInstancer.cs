using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable Instancer of type `AmmoSlot`. Inherits from `AtomVariableInstancer&lt;AmmoSlotVariable, AmmoSlotPair, AmmoSlot, AmmoSlotEvent, AmmoSlotPairEvent, AmmoSlotAmmoSlotFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/AmmoSlot Variable Instancer")]
    public class AmmoSlotVariableInstancer : AtomVariableInstancer<
        AmmoSlotVariable,
        AmmoSlotPair,
        AmmoSlot,
        AmmoSlotEvent,
        AmmoSlotPairEvent,
        AmmoSlotAmmoSlotFunction>
    { }
}
