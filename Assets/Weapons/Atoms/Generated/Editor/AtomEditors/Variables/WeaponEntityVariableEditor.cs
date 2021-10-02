using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `WeaponEntity`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(WeaponEntityVariable))]
    public sealed class WeaponEntityVariableEditor : AtomVariableEditor<WeaponEntity, WeaponEntityPair> { }
}
