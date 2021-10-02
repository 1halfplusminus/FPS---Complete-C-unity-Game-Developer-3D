using System;
using UnityAtoms.BaseAtoms;
using Cinemachine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Reference of type `Cinemachine.CinemachineVirtualCamera`. Inherits from `AtomReference&lt;Cinemachine.CinemachineVirtualCamera, CinemachineVirtualCameraPair, CinemachineVirtualCameraConstant, CinemachineVirtualCameraVariable, CinemachineVirtualCameraEvent, CinemachineVirtualCameraPairEvent, CinemachineVirtualCameraCinemachineVirtualCameraFunction, CinemachineVirtualCameraVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class CinemachineVirtualCameraReference : AtomReference<
        Cinemachine.CinemachineVirtualCamera,
        CinemachineVirtualCameraPair,
        CinemachineVirtualCameraConstant,
        CinemachineVirtualCameraVariable,
        CinemachineVirtualCameraEvent,
        CinemachineVirtualCameraPairEvent,
        CinemachineVirtualCameraCinemachineVirtualCameraFunction,
        CinemachineVirtualCameraVariableInstancer>, IEquatable<CinemachineVirtualCameraReference>
    {
        public CinemachineVirtualCameraReference() : base() { }
        public CinemachineVirtualCameraReference(Cinemachine.CinemachineVirtualCamera value) : base(value) { }
        public bool Equals(CinemachineVirtualCameraReference other) { return base.Equals(other); }
        protected override bool ValueEquals(Cinemachine.CinemachineVirtualCamera other)
        {
            throw new NotImplementedException();
        }
    }
}
