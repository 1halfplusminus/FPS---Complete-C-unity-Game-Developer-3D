using UnityEngine;
using UnityAtoms.BaseAtoms;
using Cinemachine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Set variable value Action of type `Cinemachine.CinemachineVirtualCamera`. Inherits from `SetVariableValue&lt;Cinemachine.CinemachineVirtualCamera, CinemachineVirtualCameraPair, CinemachineVirtualCameraVariable, CinemachineVirtualCameraConstant, CinemachineVirtualCameraReference, CinemachineVirtualCameraEvent, CinemachineVirtualCameraPairEvent, CinemachineVirtualCameraVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/CinemachineVirtualCamera", fileName = "SetCinemachineVirtualCameraVariableValue")]
    public sealed class SetCinemachineVirtualCameraVariableValue : SetVariableValue<
        Cinemachine.CinemachineVirtualCamera,
        CinemachineVirtualCameraPair,
        CinemachineVirtualCameraVariable,
        CinemachineVirtualCameraConstant,
        CinemachineVirtualCameraReference,
        CinemachineVirtualCameraEvent,
        CinemachineVirtualCameraPairEvent,
        CinemachineVirtualCameraCinemachineVirtualCameraFunction,
        CinemachineVirtualCameraVariableInstancer>
    { }
}
