#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `GameObjectEntity`. Inherits from `AtomDrawer&lt;GameObjectEntityConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(GameObjectEntityConstant))]
    public class GameObjectEntityConstantDrawer : VariableDrawer<GameObjectEntityConstant> { }
}
#endif
