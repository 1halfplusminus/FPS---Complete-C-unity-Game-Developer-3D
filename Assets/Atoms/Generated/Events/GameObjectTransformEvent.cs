using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `GameObjectTransform`. Inherits from `AtomEvent&lt;GameObjectTransform&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/GameObjectTransform", fileName = "GameObjectTransformEvent")]
    public sealed class GameObjectTransformEvent : AtomEvent<GameObjectTransform>
    {
    }
}
