#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `GameObjectTransformPair`. Inherits from `AtomEventEditor&lt;GameObjectTransformPair, GameObjectTransformPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(GameObjectTransformPairEvent))]
    public sealed class GameObjectTransformPairEventEditor : AtomEventEditor<GameObjectTransformPair, GameObjectTransformPairEvent> { }
}
#endif
