using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `HealthCreated`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(HealthCreatedVariable))]
    public sealed class HealthCreatedVariableEditor : AtomVariableEditor<HealthCreated, HealthCreatedPair> { }
}
