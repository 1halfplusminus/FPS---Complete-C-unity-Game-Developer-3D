using UnityEngine;
using System;
using Cinemachine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `Cinemachine.CinemachineVirtualCamera`. Inherits from `AtomVariable&lt;Cinemachine.CinemachineVirtualCamera, CinemachineVirtualCameraPair, CinemachineVirtualCameraEvent, CinemachineVirtualCameraPairEvent, CinemachineVirtualCameraCinemachineVirtualCameraFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/CinemachineVirtualCamera", fileName = "CinemachineVirtualCameraVariable")]
    public sealed class CinemachineVirtualCameraVariable : AtomVariable<Cinemachine.CinemachineVirtualCamera, CinemachineVirtualCameraPair, CinemachineVirtualCameraEvent, CinemachineVirtualCameraPairEvent, CinemachineVirtualCameraCinemachineVirtualCameraFunction>
    {
        protected override bool ValueEquals(Cinemachine.CinemachineVirtualCamera other)
        {
            throw new NotImplementedException();
        }
    }
}
