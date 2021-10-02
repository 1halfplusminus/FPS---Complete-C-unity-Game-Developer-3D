using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `EffectPair`. Inherits from `AtomEvent&lt;EffectPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/EffectPair", fileName = "EffectPairEvent")]
    public sealed class EffectPairEvent : AtomEvent<EffectPair>
    {
    }
}
