using UnityEngine;
using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `Shoot`. Inherits from `AtomVariable&lt;Shoot, ShootPair, ShootEvent, ShootPairEvent, ShootShootFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Shoot", fileName = "ShootVariable")]
    public sealed class ShootVariable : AtomVariable<Shoot, ShootPair, ShootEvent, ShootPairEvent, ShootShootFunction>
    {
        protected override bool ValueEquals(Shoot other)
        {
            throw new NotImplementedException();
        }
    }
}
