#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `GameObjectTransform`. Inherits from `AtomEventEditor&lt;GameObjectTransform, GameObjectTransformEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(GameObjectTransformEvent))]
    public sealed class GameObjectTransformEventEditor : AtomEventEditor<GameObjectTransform, GameObjectTransformEvent> { }
}
#endif
