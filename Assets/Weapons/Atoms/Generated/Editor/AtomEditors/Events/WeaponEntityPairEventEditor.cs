#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `WeaponEntityPair`. Inherits from `AtomEventEditor&lt;WeaponEntityPair, WeaponEntityPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(WeaponEntityPairEvent))]
    public sealed class WeaponEntityPairEventEditor : AtomEventEditor<WeaponEntityPair, WeaponEntityPairEvent> { }
}
#endif
