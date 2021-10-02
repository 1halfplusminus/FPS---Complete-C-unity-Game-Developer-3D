using System;
using UnityEngine.Events;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// None generic Unity Event of type `Shoot`. Inherits from `UnityEvent&lt;Shoot&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ShootUnityEvent : UnityEvent<Shoot> { }
}
