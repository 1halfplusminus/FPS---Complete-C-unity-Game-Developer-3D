#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `Weapon`. Inherits from `AtomDrawer&lt;WeaponConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(WeaponConstant))]
    public class WeaponConstantDrawer : VariableDrawer<WeaponConstant> { }
}
#endif
