using UnityEngine;
using Cinemachine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `Cinemachine.CinemachineVirtualCamera`. Inherits from `AtomEventReferenceListener&lt;Cinemachine.CinemachineVirtualCamera, CinemachineVirtualCameraEvent, CinemachineVirtualCameraEventReference, CinemachineVirtualCameraUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/CinemachineVirtualCamera Event Reference Listener")]
    public sealed class CinemachineVirtualCameraEventReferenceListener : AtomEventReferenceListener<
        Cinemachine.CinemachineVirtualCamera,
        CinemachineVirtualCameraEvent,
        CinemachineVirtualCameraEventReference,
        CinemachineVirtualCameraUnityEvent>
    { }
}
