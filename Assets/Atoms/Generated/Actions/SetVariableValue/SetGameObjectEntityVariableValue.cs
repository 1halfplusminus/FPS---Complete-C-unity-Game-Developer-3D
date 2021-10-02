using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Set variable value Action of type `GameObjectEntity`. Inherits from `SetVariableValue&lt;GameObjectEntity, GameObjectEntityPair, GameObjectEntityVariable, GameObjectEntityConstant, GameObjectEntityReference, GameObjectEntityEvent, GameObjectEntityPairEvent, GameObjectEntityVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/GameObjectEntity", fileName = "SetGameObjectEntityVariableValue")]
    public sealed class SetGameObjectEntityVariableValue : SetVariableValue<
        GameObjectEntity,
        GameObjectEntityPair,
        GameObjectEntityVariable,
        GameObjectEntityConstant,
        GameObjectEntityReference,
        GameObjectEntityEvent,
        GameObjectEntityPairEvent,
        GameObjectEntityGameObjectEntityFunction,
        GameObjectEntityVariableInstancer>
    { }
}
