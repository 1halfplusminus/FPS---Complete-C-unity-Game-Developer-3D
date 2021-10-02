#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `GameObjectTransform`. Inherits from `AtomDrawer&lt;GameObjectTransformValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(GameObjectTransformValueList))]
    public class GameObjectTransformValueListDrawer : AtomDrawer<GameObjectTransformValueList> { }
}
#endif
