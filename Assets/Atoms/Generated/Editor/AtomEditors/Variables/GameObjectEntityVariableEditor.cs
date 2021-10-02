using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `GameObjectEntity`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(GameObjectEntityVariable))]
    public sealed class GameObjectEntityVariableEditor : AtomVariableEditor<GameObjectEntity, GameObjectEntityPair> { }
}
