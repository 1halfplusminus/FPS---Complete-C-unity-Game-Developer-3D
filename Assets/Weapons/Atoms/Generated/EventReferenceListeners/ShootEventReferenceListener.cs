using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `Shoot`. Inherits from `AtomEventReferenceListener&lt;Shoot, ShootEvent, ShootEventReference, ShootUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Shoot Event Reference Listener")]
    public sealed class ShootEventReferenceListener : AtomEventReferenceListener<
        Shoot,
        ShootEvent,
        ShootEventReference,
        ShootUnityEvent>
    { }
}
