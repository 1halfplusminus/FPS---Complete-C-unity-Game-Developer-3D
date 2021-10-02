using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Set variable value Action of type `Hit`. Inherits from `SetVariableValue&lt;Hit, HitPair, HitVariable, HitConstant, HitReference, HitEvent, HitPairEvent, HitVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Hit", fileName = "SetHitVariableValue")]
    public sealed class SetHitVariableValue : SetVariableValue<
        Hit,
        HitPair,
        HitVariable,
        HitConstant,
        HitReference,
        HitEvent,
        HitPairEvent,
        HitHitFunction,
        HitVariableInstancer>
    { }
}
