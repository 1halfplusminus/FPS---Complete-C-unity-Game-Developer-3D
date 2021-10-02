using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `Shoot`. Inherits from `AtomEventReference&lt;Shoot, ShootVariable, ShootEvent, ShootVariableInstancer, ShootEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ShootEventReference : AtomEventReference<
        Shoot,
        ShootVariable,
        ShootEvent,
        ShootVariableInstancer,
        ShootEventInstancer>, IGetEvent 
    { }
}
