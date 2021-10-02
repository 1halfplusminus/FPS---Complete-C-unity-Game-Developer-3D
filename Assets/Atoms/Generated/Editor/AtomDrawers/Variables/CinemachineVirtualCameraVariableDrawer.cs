#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `Cinemachine.CinemachineVirtualCamera`. Inherits from `AtomDrawer&lt;CinemachineVirtualCameraVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(CinemachineVirtualCameraVariable))]
    public class CinemachineVirtualCameraVariableDrawer : VariableDrawer<CinemachineVirtualCameraVariable> { }
}
#endif
