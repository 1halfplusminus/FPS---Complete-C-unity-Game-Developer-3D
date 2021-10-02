#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `Weapon`. Inherits from `AtomDrawer&lt;WeaponVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(WeaponVariable))]
    public class WeaponVariableDrawer : VariableDrawer<WeaponVariable> { }
}
#endif
