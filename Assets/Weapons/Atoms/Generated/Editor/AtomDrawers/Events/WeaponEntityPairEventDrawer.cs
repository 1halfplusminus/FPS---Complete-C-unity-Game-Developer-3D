#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `WeaponEntityPair`. Inherits from `AtomDrawer&lt;WeaponEntityPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(WeaponEntityPairEvent))]
    public class WeaponEntityPairEventDrawer : AtomDrawer<WeaponEntityPairEvent> { }
}
#endif
