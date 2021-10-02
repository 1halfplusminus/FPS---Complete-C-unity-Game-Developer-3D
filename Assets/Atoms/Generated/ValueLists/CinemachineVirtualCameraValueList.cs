using UnityEngine;
using Cinemachine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Value List of type `Cinemachine.CinemachineVirtualCamera`. Inherits from `AtomValueList&lt;Cinemachine.CinemachineVirtualCamera, CinemachineVirtualCameraEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/CinemachineVirtualCamera", fileName = "CinemachineVirtualCameraValueList")]
    public sealed class CinemachineVirtualCameraValueList : AtomValueList<Cinemachine.CinemachineVirtualCamera, CinemachineVirtualCameraEvent> { }
}
