#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `Shoot`. Inherits from `AtomDrawer&lt;ShootVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ShootVariable))]
    public class ShootVariableDrawer : VariableDrawer<ShootVariable> { }
}
#endif
