#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `GameObjectTransform`. Inherits from `AtomDrawer&lt;GameObjectTransformVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(GameObjectTransformVariable))]
    public class GameObjectTransformVariableDrawer : VariableDrawer<GameObjectTransformVariable> { }
}
#endif
