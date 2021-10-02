#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Cinemachine.CinemachineVirtualCamera`. Inherits from `AtomDrawer&lt;CinemachineVirtualCameraEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(CinemachineVirtualCameraEvent))]
    public class CinemachineVirtualCameraEventDrawer : AtomDrawer<CinemachineVirtualCameraEvent> { }
}
#endif
