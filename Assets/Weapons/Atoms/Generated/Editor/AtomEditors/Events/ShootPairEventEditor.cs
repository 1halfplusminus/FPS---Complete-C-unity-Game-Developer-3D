#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `ShootPair`. Inherits from `AtomEventEditor&lt;ShootPair, ShootPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(ShootPairEvent))]
    public sealed class ShootPairEventEditor : AtomEventEditor<ShootPair, ShootPairEvent> { }
}
#endif
