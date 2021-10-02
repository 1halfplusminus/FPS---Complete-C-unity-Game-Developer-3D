using UnityEditor;
using UnityAtoms.Editor;
using Cinemachine;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `Cinemachine.CinemachineVirtualCamera`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(CinemachineVirtualCameraVariable))]
    public sealed class CinemachineVirtualCameraVariableEditor : AtomVariableEditor<Cinemachine.CinemachineVirtualCamera, CinemachineVirtualCameraPair> { }
}
