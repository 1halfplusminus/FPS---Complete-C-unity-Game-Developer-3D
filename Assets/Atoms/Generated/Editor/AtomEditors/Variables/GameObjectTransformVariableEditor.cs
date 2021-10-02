using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `GameObjectTransform`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(GameObjectTransformVariable))]
    public sealed class GameObjectTransformVariableEditor : AtomVariableEditor<GameObjectTransform, GameObjectTransformPair> { }
}
