#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `Hit`. Inherits from `AtomDrawer&lt;HitVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(HitVariable))]
    public class HitVariableDrawer : VariableDrawer<HitVariable> { }
}
#endif
