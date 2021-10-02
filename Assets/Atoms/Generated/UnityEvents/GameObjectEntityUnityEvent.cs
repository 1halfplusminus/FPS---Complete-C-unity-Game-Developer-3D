using System;
using UnityEngine.Events;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// None generic Unity Event of type `GameObjectEntity`. Inherits from `UnityEvent&lt;GameObjectEntity&gt;`.
    /// </summary>
    [Serializable]
    public sealed class GameObjectEntityUnityEvent : UnityEvent<GameObjectEntity> { }
}
