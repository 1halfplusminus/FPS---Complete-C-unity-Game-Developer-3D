using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `HealthCreated`. Inherits from `AtomEventInstancer&lt;HealthCreated, HealthCreatedEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/HealthCreated Event Instancer")]
    public class HealthCreatedEventInstancer : AtomEventInstancer<HealthCreated, HealthCreatedEvent> { }
}
