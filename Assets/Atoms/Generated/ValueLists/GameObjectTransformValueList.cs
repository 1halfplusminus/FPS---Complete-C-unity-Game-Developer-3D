using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Value List of type `GameObjectTransform`. Inherits from `AtomValueList&lt;GameObjectTransform, GameObjectTransformEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/GameObjectTransform", fileName = "GameObjectTransformValueList")]
    public sealed class GameObjectTransformValueList : AtomValueList<GameObjectTransform, GameObjectTransformEvent> { }
}
