using System;
using UnityEngine.Events;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// None generic Unity Event of type `WeaponPair`. Inherits from `UnityEvent&lt;WeaponPair&gt;`.
    /// </summary>
    [Serializable]
    public sealed class WeaponPairUnityEvent : UnityEvent<WeaponPair> { }
}
