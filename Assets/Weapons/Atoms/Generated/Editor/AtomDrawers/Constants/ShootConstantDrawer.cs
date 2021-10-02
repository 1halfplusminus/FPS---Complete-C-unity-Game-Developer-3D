#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `Shoot`. Inherits from `AtomDrawer&lt;ShootConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ShootConstant))]
    public class ShootConstantDrawer : VariableDrawer<ShootConstant> { }
}
#endif
