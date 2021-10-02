using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `Effect`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(EffectVariable))]
    public sealed class EffectVariableEditor : AtomVariableEditor<Effect, EffectPair> { }
}
