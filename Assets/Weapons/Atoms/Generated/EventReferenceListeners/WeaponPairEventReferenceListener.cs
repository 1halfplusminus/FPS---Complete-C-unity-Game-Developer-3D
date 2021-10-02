using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `WeaponPair`. Inherits from `AtomEventReferenceListener&lt;WeaponPair, WeaponPairEvent, WeaponPairEventReference, WeaponPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/WeaponPair Event Reference Listener")]
    public sealed class WeaponPairEventReferenceListener : AtomEventReferenceListener<
        WeaponPair,
        WeaponPairEvent,
        WeaponPairEventReference,
        WeaponPairUnityEvent>
    { }
}
