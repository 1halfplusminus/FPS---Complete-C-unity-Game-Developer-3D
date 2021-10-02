#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Shoot`. Inherits from `AtomDrawer&lt;ShootEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ShootEvent))]
    public class ShootEventDrawer : AtomDrawer<ShootEvent> { }
}
#endif
