using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `Hit`. Inherits from `AtomEventReferenceListener&lt;Hit, HitEvent, HitEventReference, HitUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Hit Event Reference Listener")]
    public sealed class HitEventReferenceListener : AtomEventReferenceListener<
        Hit,
        HitEvent,
        HitEventReference,
        HitUnityEvent>
    { }
}
