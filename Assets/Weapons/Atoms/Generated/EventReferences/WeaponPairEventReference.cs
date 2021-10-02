using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `WeaponPair`. Inherits from `AtomEventReference&lt;WeaponPair, WeaponVariable, WeaponPairEvent, WeaponVariableInstancer, WeaponPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class WeaponPairEventReference : AtomEventReference<
        WeaponPair,
        WeaponVariable,
        WeaponPairEvent,
        WeaponVariableInstancer,
        WeaponPairEventInstancer>, IGetEvent 
    { }
}
