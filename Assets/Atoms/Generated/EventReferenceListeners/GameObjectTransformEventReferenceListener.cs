using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `GameObjectTransform`. Inherits from `AtomEventReferenceListener&lt;GameObjectTransform, GameObjectTransformEvent, GameObjectTransformEventReference, GameObjectTransformUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/GameObjectTransform Event Reference Listener")]
    public sealed class GameObjectTransformEventReferenceListener : AtomEventReferenceListener<
        GameObjectTransform,
        GameObjectTransformEvent,
        GameObjectTransformEventReference,
        GameObjectTransformUnityEvent>
    { }
}
