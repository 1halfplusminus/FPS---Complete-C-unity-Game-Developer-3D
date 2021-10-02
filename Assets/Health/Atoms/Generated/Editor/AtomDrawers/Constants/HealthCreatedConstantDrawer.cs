#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `HealthCreated`. Inherits from `AtomDrawer&lt;HealthCreatedConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(HealthCreatedConstant))]
    public class HealthCreatedConstantDrawer : VariableDrawer<HealthCreatedConstant> { }
}
#endif
