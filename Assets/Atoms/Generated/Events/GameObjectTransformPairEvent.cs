using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `GameObjectTransformPair`. Inherits from `AtomEvent&lt;GameObjectTransformPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/GameObjectTransformPair", fileName = "GameObjectTransformPairEvent")]
    public sealed class GameObjectTransformPairEvent : AtomEvent<GameObjectTransformPair>
    {
    }
}
