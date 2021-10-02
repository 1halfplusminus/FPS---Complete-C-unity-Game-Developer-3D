using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `WeaponEntity`. Inherits from `AtomEvent&lt;WeaponEntity&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/WeaponEntity", fileName = "WeaponEntityEvent")]
    public sealed class WeaponEntityEvent : AtomEvent<WeaponEntity>
    {
    }
}
