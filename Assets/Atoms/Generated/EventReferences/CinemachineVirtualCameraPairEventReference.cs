using System;
using Cinemachine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `CinemachineVirtualCameraPair`. Inherits from `AtomEventReference&lt;CinemachineVirtualCameraPair, CinemachineVirtualCameraVariable, CinemachineVirtualCameraPairEvent, CinemachineVirtualCameraVariableInstancer, CinemachineVirtualCameraPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class CinemachineVirtualCameraPairEventReference : AtomEventReference<
        CinemachineVirtualCameraPair,
        CinemachineVirtualCameraVariable,
        CinemachineVirtualCameraPairEvent,
        CinemachineVirtualCameraVariableInstancer,
        CinemachineVirtualCameraPairEventInstancer>, IGetEvent 
    { }
}
