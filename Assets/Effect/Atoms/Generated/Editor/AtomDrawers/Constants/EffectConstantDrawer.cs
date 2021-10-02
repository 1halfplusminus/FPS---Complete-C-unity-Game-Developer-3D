#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `Effect`. Inherits from `AtomDrawer&lt;EffectConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(EffectConstant))]
    public class EffectConstantDrawer : VariableDrawer<EffectConstant> { }
}
#endif
