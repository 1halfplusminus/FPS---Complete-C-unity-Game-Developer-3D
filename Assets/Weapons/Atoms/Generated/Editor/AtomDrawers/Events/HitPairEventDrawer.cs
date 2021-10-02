#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `HitPair`. Inherits from `AtomDrawer&lt;HitPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(HitPairEvent))]
    public class HitPairEventDrawer : AtomDrawer<HitPairEvent> { }
}
#endif
