#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Shoot`. Inherits from `AtomEventEditor&lt;Shoot, ShootEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(ShootEvent))]
    public sealed class ShootEventEditor : AtomEventEditor<Shoot, ShootEvent> { }
}
#endif
