#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `WeaponPair`. Inherits from `AtomDrawer&lt;WeaponPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(WeaponPairEvent))]
    public class WeaponPairEventDrawer : AtomDrawer<WeaponPairEvent> { }
}
#endif
