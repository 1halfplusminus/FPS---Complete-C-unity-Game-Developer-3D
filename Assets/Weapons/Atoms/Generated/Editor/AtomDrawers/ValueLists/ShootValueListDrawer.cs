#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `Shoot`. Inherits from `AtomDrawer&lt;ShootValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ShootValueList))]
    public class ShootValueListDrawer : AtomDrawer<ShootValueList> { }
}
#endif
