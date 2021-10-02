using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable Instancer of type `Hit`. Inherits from `AtomVariableInstancer&lt;HitVariable, HitPair, Hit, HitEvent, HitPairEvent, HitHitFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Hit Variable Instancer")]
    public class HitVariableInstancer : AtomVariableInstancer<
        HitVariable,
        HitPair,
        Hit,
        HitEvent,
        HitPairEvent,
        HitHitFunction>
    { }
}
