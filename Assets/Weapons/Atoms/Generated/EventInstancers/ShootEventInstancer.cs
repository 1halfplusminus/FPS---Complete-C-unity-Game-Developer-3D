using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `Shoot`. Inherits from `AtomEventInstancer&lt;Shoot, ShootEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/Shoot Event Instancer")]
    public class ShootEventInstancer : AtomEventInstancer<Shoot, ShootEvent> { }
}
