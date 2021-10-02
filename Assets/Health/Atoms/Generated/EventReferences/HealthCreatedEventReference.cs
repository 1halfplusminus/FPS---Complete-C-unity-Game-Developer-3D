using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `HealthCreated`. Inherits from `AtomEventReference&lt;HealthCreated, HealthCreatedVariable, HealthCreatedEvent, HealthCreatedVariableInstancer, HealthCreatedEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class HealthCreatedEventReference : AtomEventReference<
        HealthCreated,
        HealthCreatedVariable,
        HealthCreatedEvent,
        HealthCreatedVariableInstancer,
        HealthCreatedEventInstancer>, IGetEvent 
    { }
}
