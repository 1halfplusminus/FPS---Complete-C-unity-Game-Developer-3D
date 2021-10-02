using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `GameObjectTransformPair`. Inherits from `AtomEventReferenceListener&lt;GameObjectTransformPair, GameObjectTransformPairEvent, GameObjectTransformPairEventReference, GameObjectTransformPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/GameObjectTransformPair Event Reference Listener")]
    public sealed class GameObjectTransformPairEventReferenceListener : AtomEventReferenceListener<
        GameObjectTransformPair,
        GameObjectTransformPairEvent,
        GameObjectTransformPairEventReference,
        GameObjectTransformPairUnityEvent>
    { }
}
