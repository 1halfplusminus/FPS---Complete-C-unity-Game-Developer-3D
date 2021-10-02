#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `GameObjectEntityPair`. Inherits from `AtomEventEditor&lt;GameObjectEntityPair, GameObjectEntityPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(GameObjectEntityPairEvent))]
    public sealed class GameObjectEntityPairEventEditor : AtomEventEditor<GameObjectEntityPair, GameObjectEntityPairEvent> { }
}
#endif
