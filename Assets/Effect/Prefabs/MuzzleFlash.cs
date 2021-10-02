using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuzzleFlash : PlayableComponent
{

    [SerializeField] UseEntity useEntity;

    [SerializeField] UseWeaponPivot usePivot;
    new ParticleSystem particleSystem;

    override public void Play(Effect effect)
    {
        Debug.Log("Play muzzle flash");
        if (String.IsNullOrEmpty(effect.Parent) == false)
        {
            var parent = useEntity.Get(effect.Parent);
            if (parent != null)
            {
                var pivot = usePivot.GetPivot(effect.Parent);
                var instance = Instantiate(gameObject, pivot.transform);
                var ps = instance.GetComponent<ParticleSystem>();
                var main = ps.main;
                main.simulationSpace = ParticleSystemSimulationSpace.Custom;
                main.customSimulationSpace = pivot.transform;
                ps.Play();
                Debug.Log("Play at source  effect at : " + effect.Source + " parent to : " + parent.Value.name);
            }

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<DestroyWhenParticleSystemIsDead>();
    }
}
