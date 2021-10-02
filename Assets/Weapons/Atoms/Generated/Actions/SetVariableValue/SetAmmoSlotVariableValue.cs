using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Set variable value Action of type `AmmoSlot`. Inherits from `SetVariableValue&lt;AmmoSlot, AmmoSlotPair, AmmoSlotVariable, AmmoSlotConstant, AmmoSlotReference, AmmoSlotEvent, AmmoSlotPairEvent, AmmoSlotVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/AmmoSlot", fileName = "SetAmmoSlotVariableValue")]
    public sealed class SetAmmoSlotVariableValue : SetVariableValue<
        AmmoSlot,
        AmmoSlotPair,
        AmmoSlotVariable,
        AmmoSlotConstant,
        AmmoSlotReference,
        AmmoSlotEvent,
        AmmoSlotPairEvent,
        AmmoSlotAmmoSlotFunction,
        AmmoSlotVariableInstancer>
    { }
}
