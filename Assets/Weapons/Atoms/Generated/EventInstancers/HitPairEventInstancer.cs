using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `HitPair`. Inherits from `AtomEventInstancer&lt;HitPair, HitPairEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/HitPair Event Instancer")]
    public class HitPairEventInstancer : AtomEventInstancer<HitPair, HitPairEvent> { }
}
