using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `Weapon`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(WeaponVariable))]
    public sealed class WeaponVariableEditor : AtomVariableEditor<Weapon, WeaponPair> { }
}
