#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `HealthCreated`. Inherits from `AtomDrawer&lt;HealthCreatedValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(HealthCreatedValueList))]
    public class HealthCreatedValueListDrawer : AtomDrawer<HealthCreatedValueList> { }
}
#endif
