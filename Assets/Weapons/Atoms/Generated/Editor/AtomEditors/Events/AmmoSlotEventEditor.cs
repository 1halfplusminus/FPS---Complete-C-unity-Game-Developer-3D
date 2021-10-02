#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `AmmoSlot`. Inherits from `AtomEventEditor&lt;AmmoSlot, AmmoSlotEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(AmmoSlotEvent))]
    public sealed class AmmoSlotEventEditor : AtomEventEditor<AmmoSlot, AmmoSlotEvent> { }
}
#endif
