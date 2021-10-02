using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable Instancer of type `Shoot`. Inherits from `AtomVariableInstancer&lt;ShootVariable, ShootPair, Shoot, ShootEvent, ShootPairEvent, ShootShootFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Shoot Variable Instancer")]
    public class ShootVariableInstancer : AtomVariableInstancer<
        ShootVariable,
        ShootPair,
        Shoot,
        ShootEvent,
        ShootPairEvent,
        ShootShootFunction>
    { }
}
