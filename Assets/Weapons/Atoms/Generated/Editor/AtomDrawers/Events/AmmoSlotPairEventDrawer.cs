#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `AmmoSlotPair`. Inherits from `AtomDrawer&lt;AmmoSlotPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(AmmoSlotPairEvent))]
    public class AmmoSlotPairEventDrawer : AtomDrawer<AmmoSlotPairEvent> { }
}
#endif
