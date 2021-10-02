#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `WeaponPair`. Inherits from `AtomEventEditor&lt;WeaponPair, WeaponPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(WeaponPairEvent))]
    public sealed class WeaponPairEventEditor : AtomEventEditor<WeaponPair, WeaponPairEvent> { }
}
#endif
