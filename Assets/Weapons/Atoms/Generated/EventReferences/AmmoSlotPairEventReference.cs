using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `AmmoSlotPair`. Inherits from `AtomEventReference&lt;AmmoSlotPair, AmmoSlotVariable, AmmoSlotPairEvent, AmmoSlotVariableInstancer, AmmoSlotPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class AmmoSlotPairEventReference : AtomEventReference<
        AmmoSlotPair,
        AmmoSlotVariable,
        AmmoSlotPairEvent,
        AmmoSlotVariableInstancer,
        AmmoSlotPairEventInstancer>, IGetEvent 
    { }
}
