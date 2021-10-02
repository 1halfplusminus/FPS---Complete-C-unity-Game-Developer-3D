using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `WeaponPair`. Inherits from `AtomEvent&lt;WeaponPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/WeaponPair", fileName = "WeaponPairEvent")]
    public sealed class WeaponPairEvent : AtomEvent<WeaponPair>
    {
    }
}
