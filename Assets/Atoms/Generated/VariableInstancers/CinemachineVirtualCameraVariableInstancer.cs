using UnityEngine;
using UnityAtoms.BaseAtoms;
using Cinemachine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable Instancer of type `Cinemachine.CinemachineVirtualCamera`. Inherits from `AtomVariableInstancer&lt;CinemachineVirtualCameraVariable, CinemachineVirtualCameraPair, Cinemachine.CinemachineVirtualCamera, CinemachineVirtualCameraEvent, CinemachineVirtualCameraPairEvent, CinemachineVirtualCameraCinemachineVirtualCameraFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/CinemachineVirtualCamera Variable Instancer")]
    public class CinemachineVirtualCameraVariableInstancer : AtomVariableInstancer<
        CinemachineVirtualCameraVariable,
        CinemachineVirtualCameraPair,
        Cinemachine.CinemachineVirtualCamera,
        CinemachineVirtualCameraEvent,
        CinemachineVirtualCameraPairEvent,
        CinemachineVirtualCameraCinemachineVirtualCameraFunction>
    { }
}
