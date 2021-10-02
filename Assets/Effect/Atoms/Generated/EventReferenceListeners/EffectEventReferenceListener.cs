using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `Effect`. Inherits from `AtomEventReferenceListener&lt;Effect, EffectEvent, EffectEventReference, EffectUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Effect Event Reference Listener")]
    public sealed class EffectEventReferenceListener : AtomEventReferenceListener<
        Effect,
        EffectEvent,
        EffectEventReference,
        EffectUnityEvent>
    { }
}
