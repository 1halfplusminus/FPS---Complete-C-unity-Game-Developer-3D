#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Weapon`. Inherits from `AtomEventEditor&lt;Weapon, WeaponEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(WeaponEvent))]
    public sealed class WeaponEventEditor : AtomEventEditor<Weapon, WeaponEvent> { }
}
#endif
