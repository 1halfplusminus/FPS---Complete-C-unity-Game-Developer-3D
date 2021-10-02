using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Set variable value Action of type `WeaponEntity`. Inherits from `SetVariableValue&lt;WeaponEntity, WeaponEntityPair, WeaponEntityVariable, WeaponEntityConstant, WeaponEntityReference, WeaponEntityEvent, WeaponEntityPairEvent, WeaponEntityVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/WeaponEntity", fileName = "SetWeaponEntityVariableValue")]
    public sealed class SetWeaponEntityVariableValue : SetVariableValue<
        WeaponEntity,
        WeaponEntityPair,
        WeaponEntityVariable,
        WeaponEntityConstant,
        WeaponEntityReference,
        WeaponEntityEvent,
        WeaponEntityPairEvent,
        WeaponEntityWeaponEntityFunction,
        WeaponEntityVariableInstancer>
    { }
}
