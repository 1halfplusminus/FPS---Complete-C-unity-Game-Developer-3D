using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Adds Variable Instancer's Variable of type Effect to a Collection or List on OnEnable and removes it on OnDestroy. 
    /// </summary>
    [AddComponentMenu("Unity Atoms/Sync Variable Instancer to Collection/Sync Effect Variable Instancer to Collection")]
    [EditorIcon("atom-icon-delicate")]
    public class SyncEffectVariableInstancerToCollection : SyncVariableInstancerToCollection<Effect, EffectVariable, EffectVariableInstancer> { }
}
