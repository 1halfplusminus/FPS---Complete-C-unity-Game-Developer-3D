#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using Cinemachine;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `CinemachineVirtualCameraPair`. Inherits from `AtomEventEditor&lt;CinemachineVirtualCameraPair, CinemachineVirtualCameraPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(CinemachineVirtualCameraPairEvent))]
    public sealed class CinemachineVirtualCameraPairEventEditor : AtomEventEditor<CinemachineVirtualCameraPair, CinemachineVirtualCameraPairEvent> { }
}
#endif
