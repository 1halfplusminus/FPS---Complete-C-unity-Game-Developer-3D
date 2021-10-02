using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `HealthCreated`. Inherits from `AtomEventReferenceListener&lt;HealthCreated, HealthCreatedEvent, HealthCreatedEventReference, HealthCreatedUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/HealthCreated Event Reference Listener")]
    public sealed class HealthCreatedEventReferenceListener : AtomEventReferenceListener<
        HealthCreated,
        HealthCreatedEvent,
        HealthCreatedEventReference,
        HealthCreatedUnityEvent>
    { }
}
