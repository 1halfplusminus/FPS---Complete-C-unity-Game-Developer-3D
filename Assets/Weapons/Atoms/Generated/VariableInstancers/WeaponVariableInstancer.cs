using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable Instancer of type `Weapon`. Inherits from `AtomVariableInstancer&lt;WeaponVariable, WeaponPair, Weapon, WeaponEvent, WeaponPairEvent, WeaponWeaponFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Weapon Variable Instancer")]
    public class WeaponVariableInstancer : AtomVariableInstancer<
        WeaponVariable,
        WeaponPair,
        Weapon,
        WeaponEvent,
        WeaponPairEvent,
        WeaponWeaponFunction>
    { }
}
