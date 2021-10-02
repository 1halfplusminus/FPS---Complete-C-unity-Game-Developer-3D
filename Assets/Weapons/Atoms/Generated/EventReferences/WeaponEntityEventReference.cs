using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `WeaponEntity`. Inherits from `AtomEventReference&lt;WeaponEntity, WeaponEntityVariable, WeaponEntityEvent, WeaponEntityVariableInstancer, WeaponEntityEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class WeaponEntityEventReference : AtomEventReference<
        WeaponEntity,
        WeaponEntityVariable,
        WeaponEntityEvent,
        WeaponEntityVariableInstancer,
        WeaponEntityEventInstancer>, IGetEvent 
    { }
}
