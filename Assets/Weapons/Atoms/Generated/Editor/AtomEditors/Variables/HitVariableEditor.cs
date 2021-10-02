using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `Hit`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(HitVariable))]
    public sealed class HitVariableEditor : AtomVariableEditor<Hit, HitPair> { }
}
