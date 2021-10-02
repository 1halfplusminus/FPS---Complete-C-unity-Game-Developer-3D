using System;
using UnityEngine;
using Cinemachine;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;Cinemachine.CinemachineVirtualCamera&gt;`. Inherits from `IPair&lt;Cinemachine.CinemachineVirtualCamera&gt;`.
    /// </summary>
    [Serializable]
    public struct CinemachineVirtualCameraPair : IPair<Cinemachine.CinemachineVirtualCamera>
    {
        public Cinemachine.CinemachineVirtualCamera Item1 { get => _item1; set => _item1 = value; }
        public Cinemachine.CinemachineVirtualCamera Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private Cinemachine.CinemachineVirtualCamera _item1;
        [SerializeField]
        private Cinemachine.CinemachineVirtualCamera _item2;

        public void Deconstruct(out Cinemachine.CinemachineVirtualCamera item1, out Cinemachine.CinemachineVirtualCamera item2) { item1 = Item1; item2 = Item2; }
    }
}