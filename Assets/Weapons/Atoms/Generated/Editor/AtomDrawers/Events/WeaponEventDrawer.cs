#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Weapon`. Inherits from `AtomDrawer&lt;WeaponEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(WeaponEvent))]
    public class WeaponEventDrawer : AtomDrawer<WeaponEvent> { }
}
#endif
