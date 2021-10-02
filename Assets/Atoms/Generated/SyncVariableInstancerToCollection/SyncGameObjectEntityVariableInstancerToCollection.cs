using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Adds Variable Instancer's Variable of type GameObjectEntity to a Collection or List on OnEnable and removes it on OnDestroy. 
    /// </summary>
    [AddComponentMenu("Unity Atoms/Sync Variable Instancer to Collection/Sync GameObjectEntity Variable Instancer to Collection")]
    [EditorIcon("atom-icon-delicate")]
    public class SyncGameObjectEntityVariableInstancerToCollection : SyncVariableInstancerToCollection<GameObjectEntity, GameObjectEntityVariable, GameObjectEntityVariableInstancer> { }
}
