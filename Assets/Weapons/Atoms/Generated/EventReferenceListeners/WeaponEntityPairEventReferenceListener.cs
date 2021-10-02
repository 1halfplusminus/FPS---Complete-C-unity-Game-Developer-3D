using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `WeaponEntityPair`. Inherits from `AtomEventReferenceListener&lt;WeaponEntityPair, WeaponEntityPairEvent, WeaponEntityPairEventReference, WeaponEntityPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/WeaponEntityPair Event Reference Listener")]
    public sealed class WeaponEntityPairEventReferenceListener : AtomEventReferenceListener<
        WeaponEntityPair,
        WeaponEntityPairEvent,
        WeaponEntityPairEventReference,
        WeaponEntityPairUnityEvent>
    { }
}
