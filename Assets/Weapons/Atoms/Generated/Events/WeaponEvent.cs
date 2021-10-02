using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `Weapon`. Inherits from `AtomEvent&lt;Weapon&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Weapon", fileName = "WeaponEvent")]
    public sealed class WeaponEvent : AtomEvent<Weapon>
    {
    }
}
