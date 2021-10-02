#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `EffectPair`. Inherits from `AtomDrawer&lt;EffectPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(EffectPairEvent))]
    public class EffectPairEventDrawer : AtomDrawer<EffectPairEvent> { }
}
#endif
