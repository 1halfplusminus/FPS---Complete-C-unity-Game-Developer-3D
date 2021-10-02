
using System;
using UnityAtoms;
using UnityEngine;


public interface IPlayable
{
    public void Play(Effect effect);
    public void Play();
    public void Play(Vector3 source);
    public void Play(Vector3 source, Vector3 target);

    public void Play(Transform source, Transform target);

}

public class PlayableComponent : MonoBehaviour, IPlayable
{
    public virtual void Play() { }

    public virtual void Play(Vector3 source)
    {

    }

    public virtual void Play(Vector3 source, Vector3 target)
    {

    }

    public virtual void Play(Transform source, Transform target)
    {

    }

    public virtual void Play(Effect effect)
    {

    }
}

