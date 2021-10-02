#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `AmmoSlot`. Inherits from `AtomDrawer&lt;AmmoSlotConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(AmmoSlotConstant))]
    public class AmmoSlotConstantDrawer : VariableDrawer<AmmoSlotConstant> { }
}
#endif
