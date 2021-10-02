using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `HitPair`. Inherits from `AtomEventReferenceListener&lt;HitPair, HitPairEvent, HitPairEventReference, HitPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/HitPair Event Reference Listener")]
    public sealed class HitPairEventReferenceListener : AtomEventReferenceListener<
        HitPair,
        HitPairEvent,
        HitPairEventReference,
        HitPairUnityEvent>
    { }
}
