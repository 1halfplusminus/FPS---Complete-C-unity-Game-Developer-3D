using UnityEngine;
using Cinemachine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `Cinemachine.CinemachineVirtualCamera`. Inherits from `AtomEventInstancer&lt;Cinemachine.CinemachineVirtualCamera, CinemachineVirtualCameraEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/CinemachineVirtualCamera Event Instancer")]
    public class CinemachineVirtualCameraEventInstancer : AtomEventInstancer<Cinemachine.CinemachineVirtualCamera, CinemachineVirtualCameraEvent> { }
}
