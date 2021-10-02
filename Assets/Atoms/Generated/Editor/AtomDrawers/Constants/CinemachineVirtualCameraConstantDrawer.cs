#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `Cinemachine.CinemachineVirtualCamera`. Inherits from `AtomDrawer&lt;CinemachineVirtualCameraConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(CinemachineVirtualCameraConstant))]
    public class CinemachineVirtualCameraConstantDrawer : VariableDrawer<CinemachineVirtualCameraConstant> { }
}
#endif
