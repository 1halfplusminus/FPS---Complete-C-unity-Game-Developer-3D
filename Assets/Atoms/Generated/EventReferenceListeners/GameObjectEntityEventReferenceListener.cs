using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `GameObjectEntity`. Inherits from `AtomEventReferenceListener&lt;GameObjectEntity, GameObjectEntityEvent, GameObjectEntityEventReference, GameObjectEntityUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/GameObjectEntity Event Reference Listener")]
    public sealed class GameObjectEntityEventReferenceListener : AtomEventReferenceListener<
        GameObjectEntity,
        GameObjectEntityEvent,
        GameObjectEntityEventReference,
        GameObjectEntityUnityEvent>
    { }
}
