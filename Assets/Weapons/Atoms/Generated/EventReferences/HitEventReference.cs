using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `Hit`. Inherits from `AtomEventReference&lt;Hit, HitVariable, HitEvent, HitVariableInstancer, HitEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class HitEventReference : AtomEventReference<
        Hit,
        HitVariable,
        HitEvent,
        HitVariableInstancer,
        HitEventInstancer>, IGetEvent 
    { }
}
