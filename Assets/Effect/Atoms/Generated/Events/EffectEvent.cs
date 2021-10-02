using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `Effect`. Inherits from `AtomEvent&lt;Effect&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Effect", fileName = "EffectEvent")]
    public sealed class EffectEvent : AtomEvent<Effect>
    {
    }
}
