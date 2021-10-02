using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `Weapon`. Inherits from `AtomEventReference&lt;Weapon, WeaponVariable, WeaponEvent, WeaponVariableInstancer, WeaponEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class WeaponEventReference : AtomEventReference<
        Weapon,
        WeaponVariable,
        WeaponEvent,
        WeaponVariableInstancer,
        WeaponEventInstancer>, IGetEvent 
    { }
}
