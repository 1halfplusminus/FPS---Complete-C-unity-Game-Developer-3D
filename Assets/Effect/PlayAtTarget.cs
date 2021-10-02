
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
class PlayAtTarget : PlayableComponent
{
    [SerializeField] Vector3 offset = Vector3.zero;
    new ParticleSystem particleSystem;
    override public void Play(Effect effect)
    {
        var instance = Instantiate(gameObject, effect.Target + offset, Quaternion.identity);
        Debug.Log("Play at target  effect at : " + effect.Target);

    }
    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<DestroyWhenParticleSystemIsDead>();
    }

}
