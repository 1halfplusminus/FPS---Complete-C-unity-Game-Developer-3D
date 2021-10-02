using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable Instancer of type `GameObjectEntity`. Inherits from `AtomVariableInstancer&lt;GameObjectEntityVariable, GameObjectEntityPair, GameObjectEntity, GameObjectEntityEvent, GameObjectEntityPairEvent, GameObjectEntityGameObjectEntityFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/GameObjectEntity Variable Instancer")]
    public class GameObjectEntityVariableInstancer : AtomVariableInstancer<
        GameObjectEntityVariable,
        GameObjectEntityPair,
        GameObjectEntity,
        GameObjectEntityEvent,
        GameObjectEntityPairEvent,
        GameObjectEntityGameObjectEntityFunction>
    { }
}
