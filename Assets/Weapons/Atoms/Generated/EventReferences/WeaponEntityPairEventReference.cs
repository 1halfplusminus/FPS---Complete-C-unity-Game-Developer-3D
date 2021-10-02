using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `WeaponEntityPair`. Inherits from `AtomEventReference&lt;WeaponEntityPair, WeaponEntityVariable, WeaponEntityPairEvent, WeaponEntityVariableInstancer, WeaponEntityPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class WeaponEntityPairEventReference : AtomEventReference<
        WeaponEntityPair,
        WeaponEntityVariable,
        WeaponEntityPairEvent,
        WeaponEntityVariableInstancer,
        WeaponEntityPairEventInstancer>, IGetEvent 
    { }
}
