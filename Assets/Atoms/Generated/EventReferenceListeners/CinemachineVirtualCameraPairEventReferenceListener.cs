using UnityEngine;
using Cinemachine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `CinemachineVirtualCameraPair`. Inherits from `AtomEventReferenceListener&lt;CinemachineVirtualCameraPair, CinemachineVirtualCameraPairEvent, CinemachineVirtualCameraPairEventReference, CinemachineVirtualCameraPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/CinemachineVirtualCameraPair Event Reference Listener")]
    public sealed class CinemachineVirtualCameraPairEventReferenceListener : AtomEventReferenceListener<
        CinemachineVirtualCameraPair,
        CinemachineVirtualCameraPairEvent,
        CinemachineVirtualCameraPairEventReference,
        CinemachineVirtualCameraPairUnityEvent>
    { }
}
