#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Effect`. Inherits from `AtomEventEditor&lt;Effect, EffectEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(EffectEvent))]
    public sealed class EffectEventEditor : AtomEventEditor<Effect, EffectEvent> { }
}
#endif
