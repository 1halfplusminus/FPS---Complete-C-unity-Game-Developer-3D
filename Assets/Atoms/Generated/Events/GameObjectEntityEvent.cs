using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `GameObjectEntity`. Inherits from `AtomEvent&lt;GameObjectEntity&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/GameObjectEntity", fileName = "GameObjectEntityEvent")]
    public sealed class GameObjectEntityEvent : AtomEvent<GameObjectEntity>
    {
    }
}
