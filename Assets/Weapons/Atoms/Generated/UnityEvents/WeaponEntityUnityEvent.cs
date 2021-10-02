using System;
using UnityEngine.Events;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// None generic Unity Event of type `WeaponEntity`. Inherits from `UnityEvent&lt;WeaponEntity&gt;`.
    /// </summary>
    [Serializable]
    public sealed class WeaponEntityUnityEvent : UnityEvent<WeaponEntity> { }
}
