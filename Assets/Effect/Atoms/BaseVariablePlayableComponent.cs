using UnityAtoms;
using UnityEngine;

[EditorIcon("atom-icon-lush")]
[CreateAssetMenu(menuName = "Unity Atoms/Variables/PlayableEffect", fileName = "BaseVariablePlayableComponent")]
class BaseVariablePlayableComponent : AtomBaseVariable<PlayableComponent>, IPlayable
{
    public void Play()
    {
        Value.Play();
    }

    public void Play(Effect effect)
    {
        Value.Play(effect);
    }
    public void Play(Vector3 source)
    {
        Value.Play(source);
    }

    public void Play(Vector3 source, Vector3 target)
    {
        Value.Play(source, target);
    }

    public void Play(Transform source, Transform target)
    {
        Value.Play(source, target);
    }
}