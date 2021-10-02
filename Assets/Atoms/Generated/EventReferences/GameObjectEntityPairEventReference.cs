using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `GameObjectEntityPair`. Inherits from `AtomEventReference&lt;GameObjectEntityPair, GameObjectEntityVariable, GameObjectEntityPairEvent, GameObjectEntityVariableInstancer, GameObjectEntityPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class GameObjectEntityPairEventReference : AtomEventReference<
        GameObjectEntityPair,
        GameObjectEntityVariable,
        GameObjectEntityPairEvent,
        GameObjectEntityVariableInstancer,
        GameObjectEntityPairEventInstancer>, IGetEvent 
    { }
}
