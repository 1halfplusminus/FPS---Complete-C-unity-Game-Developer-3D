using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `GameObjectEntity`. Inherits from `AtomEventReference&lt;GameObjectEntity, GameObjectEntityVariable, GameObjectEntityEvent, GameObjectEntityVariableInstancer, GameObjectEntityEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class GameObjectEntityEventReference : AtomEventReference<
        GameObjectEntity,
        GameObjectEntityVariable,
        GameObjectEntityEvent,
        GameObjectEntityVariableInstancer,
        GameObjectEntityEventInstancer>, IGetEvent 
    { }
}
