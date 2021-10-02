using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `GameObjectEntityPair`. Inherits from `AtomEventReferenceListener&lt;GameObjectEntityPair, GameObjectEntityPairEvent, GameObjectEntityPairEventReference, GameObjectEntityPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/GameObjectEntityPair Event Reference Listener")]
    public sealed class GameObjectEntityPairEventReferenceListener : AtomEventReferenceListener<
        GameObjectEntityPair,
        GameObjectEntityPairEvent,
        GameObjectEntityPairEventReference,
        GameObjectEntityPairUnityEvent>
    { }
}
