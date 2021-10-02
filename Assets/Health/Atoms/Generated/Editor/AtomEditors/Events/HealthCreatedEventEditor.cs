#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `HealthCreated`. Inherits from `AtomEventEditor&lt;HealthCreated, HealthCreatedEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(HealthCreatedEvent))]
    public sealed class HealthCreatedEventEditor : AtomEventEditor<HealthCreated, HealthCreatedEvent> { }
}
#endif
