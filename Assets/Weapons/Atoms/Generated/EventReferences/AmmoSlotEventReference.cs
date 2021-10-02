using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `AmmoSlot`. Inherits from `AtomEventReference&lt;AmmoSlot, AmmoSlotVariable, AmmoSlotEvent, AmmoSlotVariableInstancer, AmmoSlotEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class AmmoSlotEventReference : AtomEventReference<
        AmmoSlot,
        AmmoSlotVariable,
        AmmoSlotEvent,
        AmmoSlotVariableInstancer,
        AmmoSlotEventInstancer>, IGetEvent 
    { }
}
