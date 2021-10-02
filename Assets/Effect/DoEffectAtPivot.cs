
using UnityEngine;
using UnityAtoms.BaseAtoms;
[CreateAssetMenu(fileName = "DoEffectAtPivot", menuName = "Zombie Runner/DoEffectAtPivot", order = 0)]
public class DoEffectAtPivot : ScriptableObject
{
    [SerializeField] PlayableComponent playable;
    [SerializeField] UseWeaponPivot usePivot;

    public void Play(GameObject gameObject)
    {
        var effect = new Effect();
        var id = gameObject.GetInstanceID().ToString();
        var pivot = usePivot.GetPivot(id);
        effect.Source = pivot.transform.position;
        effect.Parent = id;
        playable.Play(effect);
    }
}