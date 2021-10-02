using System;
using UnityEngine.Events;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// None generic Unity Event of type `HitPair`. Inherits from `UnityEvent&lt;HitPair&gt;`.
    /// </summary>
    [Serializable]
    public sealed class HitPairUnityEvent : UnityEvent<HitPair> { }
}
