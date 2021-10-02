#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `HealthCreatedPair`. Inherits from `AtomEventEditor&lt;HealthCreatedPair, HealthCreatedPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(HealthCreatedPairEvent))]
    public sealed class HealthCreatedPairEventEditor : AtomEventEditor<HealthCreatedPair, HealthCreatedPairEvent> { }
}
#endif
