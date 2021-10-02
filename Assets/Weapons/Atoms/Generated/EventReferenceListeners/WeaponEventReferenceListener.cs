using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `Weapon`. Inherits from `AtomEventReferenceListener&lt;Weapon, WeaponEvent, WeaponEventReference, WeaponUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Weapon Event Reference Listener")]
    public sealed class WeaponEventReferenceListener : AtomEventReferenceListener<
        Weapon,
        WeaponEvent,
        WeaponEventReference,
        WeaponUnityEvent>
    { }
}
