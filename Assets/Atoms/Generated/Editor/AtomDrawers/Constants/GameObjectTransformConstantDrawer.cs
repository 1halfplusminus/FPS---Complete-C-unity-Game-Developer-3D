#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `GameObjectTransform`. Inherits from `AtomDrawer&lt;GameObjectTransformConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(GameObjectTransformConstant))]
    public class GameObjectTransformConstantDrawer : VariableDrawer<GameObjectTransformConstant> { }
}
#endif
