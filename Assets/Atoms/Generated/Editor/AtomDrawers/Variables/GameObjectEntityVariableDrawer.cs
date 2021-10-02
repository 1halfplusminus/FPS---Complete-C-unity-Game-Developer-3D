#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `GameObjectEntity`. Inherits from `AtomDrawer&lt;GameObjectEntityVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(GameObjectEntityVariable))]
    public class GameObjectEntityVariableDrawer : VariableDrawer<GameObjectEntityVariable> { }
}
#endif
