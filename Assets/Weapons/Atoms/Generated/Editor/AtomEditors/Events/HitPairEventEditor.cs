#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `HitPair`. Inherits from `AtomEventEditor&lt;HitPair, HitPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(HitPairEvent))]
    public sealed class HitPairEventEditor : AtomEventEditor<HitPair, HitPairEvent> { }
}
#endif
