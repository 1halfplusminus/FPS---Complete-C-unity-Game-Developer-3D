using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Set variable value Action of type `Weapon`. Inherits from `SetVariableValue&lt;Weapon, WeaponPair, WeaponVariable, WeaponConstant, WeaponReference, WeaponEvent, WeaponPairEvent, WeaponVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Weapon", fileName = "SetWeaponVariableValue")]
    public sealed class SetWeaponVariableValue : SetVariableValue<
        Weapon,
        WeaponPair,
        WeaponVariable,
        WeaponConstant,
        WeaponReference,
        WeaponEvent,
        WeaponPairEvent,
        WeaponWeaponFunction,
        WeaponVariableInstancer>
    { }
}
