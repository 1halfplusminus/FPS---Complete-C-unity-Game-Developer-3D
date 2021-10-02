using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `GameObjectTransformPair`. Inherits from `AtomEventReference&lt;GameObjectTransformPair, GameObjectTransformVariable, GameObjectTransformPairEvent, GameObjectTransformVariableInstancer, GameObjectTransformPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class GameObjectTransformPairEventReference : AtomEventReference<
        GameObjectTransformPair,
        GameObjectTransformVariable,
        GameObjectTransformPairEvent,
        GameObjectTransformVariableInstancer,
        GameObjectTransformPairEventInstancer>, IGetEvent 
    { }
}
