using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `HitPair`. Inherits from `AtomEventReference&lt;HitPair, HitVariable, HitPairEvent, HitVariableInstancer, HitPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class HitPairEventReference : AtomEventReference<
        HitPair,
        HitVariable,
        HitPairEvent,
        HitVariableInstancer,
        HitPairEventInstancer>, IGetEvent 
    { }
}
