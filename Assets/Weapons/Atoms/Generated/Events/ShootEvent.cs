using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `Shoot`. Inherits from `AtomEvent&lt;Shoot&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Shoot", fileName = "ShootEvent")]
    public sealed class ShootEvent : AtomEvent<Shoot>
    {
    }
}
