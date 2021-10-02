#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `WeaponEntity`. Inherits from `AtomDrawer&lt;WeaponEntityValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(WeaponEntityValueList))]
    public class WeaponEntityValueListDrawer : AtomDrawer<WeaponEntityValueList> { }
}
#endif
