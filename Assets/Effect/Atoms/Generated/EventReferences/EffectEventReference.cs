using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `Effect`. Inherits from `AtomEventReference&lt;Effect, EffectVariable, EffectEvent, EffectVariableInstancer, EffectEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class EffectEventReference : AtomEventReference<
        Effect,
        EffectVariable,
        EffectEvent,
        EffectVariableInstancer,
        EffectEventInstancer>, IGetEvent 
    { }
}
