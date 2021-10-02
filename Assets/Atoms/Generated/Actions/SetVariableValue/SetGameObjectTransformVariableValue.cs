using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Set variable value Action of type `GameObjectTransform`. Inherits from `SetVariableValue&lt;GameObjectTransform, GameObjectTransformPair, GameObjectTransformVariable, GameObjectTransformConstant, GameObjectTransformReference, GameObjectTransformEvent, GameObjectTransformPairEvent, GameObjectTransformVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/GameObjectTransform", fileName = "SetGameObjectTransformVariableValue")]
    public sealed class SetGameObjectTransformVariableValue : SetVariableValue<
        GameObjectTransform,
        GameObjectTransformPair,
        GameObjectTransformVariable,
        GameObjectTransformConstant,
        GameObjectTransformReference,
        GameObjectTransformEvent,
        GameObjectTransformPairEvent,
        GameObjectTransformGameObjectTransformFunction,
        GameObjectTransformVariableInstancer>
    { }
}
