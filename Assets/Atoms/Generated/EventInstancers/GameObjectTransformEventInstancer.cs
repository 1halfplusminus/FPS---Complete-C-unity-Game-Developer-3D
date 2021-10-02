using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `GameObjectTransform`. Inherits from `AtomEventInstancer&lt;GameObjectTransform, GameObjectTransformEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/GameObjectTransform Event Instancer")]
    public class GameObjectTransformEventInstancer : AtomEventInstancer<GameObjectTransform, GameObjectTransformEvent> { }
}
