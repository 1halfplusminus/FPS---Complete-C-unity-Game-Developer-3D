#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `WeaponEntity`. Inherits from `AtomEventEditor&lt;WeaponEntity, WeaponEntityEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(WeaponEntityEvent))]
    public sealed class WeaponEntityEventEditor : AtomEventEditor<WeaponEntity, WeaponEntityEvent> { }
}
#endif
