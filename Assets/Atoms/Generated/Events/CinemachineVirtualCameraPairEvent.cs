using UnityEngine;
using Cinemachine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `CinemachineVirtualCameraPair`. Inherits from `AtomEvent&lt;CinemachineVirtualCameraPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/CinemachineVirtualCameraPair", fileName = "CinemachineVirtualCameraPairEvent")]
    public sealed class CinemachineVirtualCameraPairEvent : AtomEvent<CinemachineVirtualCameraPair>
    {
    }
}
