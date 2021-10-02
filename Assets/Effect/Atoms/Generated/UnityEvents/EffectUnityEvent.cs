using System;
using UnityEngine.Events;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// None generic Unity Event of type `Effect`. Inherits from `UnityEvent&lt;Effect&gt;`.
    /// </summary>
    [Serializable]
    public sealed class EffectUnityEvent : UnityEvent<Effect> { }
}
