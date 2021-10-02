using UnityEngine;
using Cinemachine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `Cinemachine.CinemachineVirtualCamera`. Inherits from `AtomEvent&lt;Cinemachine.CinemachineVirtualCamera&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/CinemachineVirtualCamera", fileName = "CinemachineVirtualCameraEvent")]
    public sealed class CinemachineVirtualCameraEvent : AtomEvent<Cinemachine.CinemachineVirtualCamera>
    {
    }
}
