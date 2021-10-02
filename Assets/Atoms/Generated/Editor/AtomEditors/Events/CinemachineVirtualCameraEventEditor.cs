#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using Cinemachine;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Cinemachine.CinemachineVirtualCamera`. Inherits from `AtomEventEditor&lt;Cinemachine.CinemachineVirtualCamera, CinemachineVirtualCameraEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(CinemachineVirtualCameraEvent))]
    public sealed class CinemachineVirtualCameraEventEditor : AtomEventEditor<Cinemachine.CinemachineVirtualCamera, CinemachineVirtualCameraEvent> { }
}
#endif
