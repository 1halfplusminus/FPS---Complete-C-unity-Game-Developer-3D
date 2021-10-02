#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `HealthCreated`. Inherits from `AtomDrawer&lt;HealthCreatedVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(HealthCreatedVariable))]
    public class HealthCreatedVariableDrawer : VariableDrawer<HealthCreatedVariable> { }
}
#endif
