#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Hit`. Inherits from `AtomEventEditor&lt;Hit, HitEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(HitEvent))]
    public sealed class HitEventEditor : AtomEventEditor<Hit, HitEvent> { }
}
#endif
