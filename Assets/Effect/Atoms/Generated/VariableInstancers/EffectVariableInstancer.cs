using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable Instancer of type `Effect`. Inherits from `AtomVariableInstancer&lt;EffectVariable, EffectPair, Effect, EffectEvent, EffectPairEvent, EffectEffectFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Effect Variable Instancer")]
    public class EffectVariableInstancer : AtomVariableInstancer<
        EffectVariable,
        EffectPair,
        Effect,
        EffectEvent,
        EffectPairEvent,
        EffectEffectFunction>
    { }
}
