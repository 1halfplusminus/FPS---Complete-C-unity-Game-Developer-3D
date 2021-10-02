#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Effect`. Inherits from `AtomDrawer&lt;EffectEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(EffectEvent))]
    public class EffectEventDrawer : AtomDrawer<EffectEvent> { }
}
#endif
