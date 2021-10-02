#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `AmmoSlot`. Inherits from `AtomDrawer&lt;AmmoSlotValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(AmmoSlotValueList))]
    public class AmmoSlotValueListDrawer : AtomDrawer<AmmoSlotValueList> { }
}
#endif
