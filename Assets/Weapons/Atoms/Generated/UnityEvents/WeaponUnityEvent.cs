using System;
using UnityEngine.Events;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// None generic Unity Event of type `Weapon`. Inherits from `UnityEvent&lt;Weapon&gt;`.
    /// </summary>
    [Serializable]
    public sealed class WeaponUnityEvent : UnityEvent<Weapon> { }
}
