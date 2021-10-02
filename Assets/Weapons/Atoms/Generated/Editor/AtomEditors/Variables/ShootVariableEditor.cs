using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `Shoot`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(ShootVariable))]
    public sealed class ShootVariableEditor : AtomVariableEditor<Shoot, ShootPair> { }
}
