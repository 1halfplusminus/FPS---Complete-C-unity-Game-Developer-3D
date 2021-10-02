using System;
using UnityEngine.Events;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// None generic Unity Event of type `Hit`. Inherits from `UnityEvent&lt;Hit&gt;`.
    /// </summary>
    [Serializable]
    public sealed class HitUnityEvent : UnityEvent<Hit> { }
}
