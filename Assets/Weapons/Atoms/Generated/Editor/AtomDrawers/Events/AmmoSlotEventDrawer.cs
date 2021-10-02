#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `AmmoSlot`. Inherits from `AtomDrawer&lt;AmmoSlotEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(AmmoSlotEvent))]
    public class AmmoSlotEventDrawer : AtomDrawer<AmmoSlotEvent> { }
}
#endif
