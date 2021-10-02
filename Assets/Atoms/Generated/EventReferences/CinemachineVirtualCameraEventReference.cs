using System;
using Cinemachine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `Cinemachine.CinemachineVirtualCamera`. Inherits from `AtomEventReference&lt;Cinemachine.CinemachineVirtualCamera, CinemachineVirtualCameraVariable, CinemachineVirtualCameraEvent, CinemachineVirtualCameraVariableInstancer, CinemachineVirtualCameraEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class CinemachineVirtualCameraEventReference : AtomEventReference<
        Cinemachine.CinemachineVirtualCamera,
        CinemachineVirtualCameraVariable,
        CinemachineVirtualCameraEvent,
        CinemachineVirtualCameraVariableInstancer,
        CinemachineVirtualCameraEventInstancer>, IGetEvent 
    { }
}
