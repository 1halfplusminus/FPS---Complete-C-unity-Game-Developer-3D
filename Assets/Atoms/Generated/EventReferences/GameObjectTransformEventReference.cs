using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `GameObjectTransform`. Inherits from `AtomEventReference&lt;GameObjectTransform, GameObjectTransformVariable, GameObjectTransformEvent, GameObjectTransformVariableInstancer, GameObjectTransformEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class GameObjectTransformEventReference : AtomEventReference<
        GameObjectTransform,
        GameObjectTransformVariable,
        GameObjectTransformEvent,
        GameObjectTransformVariableInstancer,
        GameObjectTransformEventInstancer>, IGetEvent 
    { }
}
