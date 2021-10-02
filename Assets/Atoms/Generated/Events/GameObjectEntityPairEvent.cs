using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `GameObjectEntityPair`. Inherits from `AtomEvent&lt;GameObjectEntityPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/GameObjectEntityPair", fileName = "GameObjectEntityPairEvent")]
    public sealed class GameObjectEntityPairEvent : AtomEvent<GameObjectEntityPair>
    {
    }
}
