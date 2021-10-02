using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `WeaponEntityPair`. Inherits from `AtomEvent&lt;WeaponEntityPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/WeaponEntityPair", fileName = "WeaponEntityPairEvent")]
    public sealed class WeaponEntityPairEvent : AtomEvent<WeaponEntityPair>
    {
    }
}
