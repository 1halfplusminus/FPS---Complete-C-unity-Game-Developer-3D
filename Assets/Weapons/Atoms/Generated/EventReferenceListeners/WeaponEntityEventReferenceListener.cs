using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `WeaponEntity`. Inherits from `AtomEventReferenceListener&lt;WeaponEntity, WeaponEntityEvent, WeaponEntityEventReference, WeaponEntityUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/WeaponEntity Event Reference Listener")]
    public sealed class WeaponEntityEventReferenceListener : AtomEventReferenceListener<
        WeaponEntity,
        WeaponEntityEvent,
        WeaponEntityEventReference,
        WeaponEntityUnityEvent>
    { }
}
