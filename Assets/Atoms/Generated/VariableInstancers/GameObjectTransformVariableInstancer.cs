using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable Instancer of type `GameObjectTransform`. Inherits from `AtomVariableInstancer&lt;GameObjectTransformVariable, GameObjectTransformPair, GameObjectTransform, GameObjectTransformEvent, GameObjectTransformPairEvent, GameObjectTransformGameObjectTransformFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/GameObjectTransform Variable Instancer")]
    public class GameObjectTransformVariableInstancer : AtomVariableInstancer<
        GameObjectTransformVariable,
        GameObjectTransformPair,
        GameObjectTransform,
        GameObjectTransformEvent,
        GameObjectTransformPairEvent,
        GameObjectTransformGameObjectTransformFunction>
    { }
}
