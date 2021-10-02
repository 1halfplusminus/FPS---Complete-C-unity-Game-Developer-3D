using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Value List of type `GameObjectEntity`. Inherits from `AtomValueList&lt;GameObjectEntity, GameObjectEntityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/GameObjectEntity", fileName = "GameObjectEntityValueList")]
    public sealed class GameObjectEntityValueList : AtomValueList<GameObjectEntity, GameObjectEntityEvent> { }
}
