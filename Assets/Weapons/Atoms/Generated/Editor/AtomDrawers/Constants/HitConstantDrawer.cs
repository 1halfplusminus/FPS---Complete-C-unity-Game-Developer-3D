#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `Hit`. Inherits from `AtomDrawer&lt;HitConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(HitConstant))]
    public class HitConstantDrawer : VariableDrawer<HitConstant> { }
}
#endif
