using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable Instancer of type `WeaponEntity`. Inherits from `AtomVariableInstancer&lt;WeaponEntityVariable, WeaponEntityPair, WeaponEntity, WeaponEntityEvent, WeaponEntityPairEvent, WeaponEntityWeaponEntityFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/WeaponEntity Variable Instancer")]
    public class WeaponEntityVariableInstancer : AtomVariableInstancer<
        WeaponEntityVariable,
        WeaponEntityPair,
        WeaponEntity,
        WeaponEntityEvent,
        WeaponEntityPairEvent,
        WeaponEntityWeaponEntityFunction>
    { }
}
