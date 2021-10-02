#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `Hit`. Inherits from `AtomDrawer&lt;HitValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(HitValueList))]
    public class HitValueListDrawer : AtomDrawer<HitValueList> { }
}
#endif
