#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `CinemachineVirtualCameraPair`. Inherits from `AtomDrawer&lt;CinemachineVirtualCameraPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(CinemachineVirtualCameraPairEvent))]
    public class CinemachineVirtualCameraPairEventDrawer : AtomDrawer<CinemachineVirtualCameraPairEvent> { }
}
#endif
