using UnityEngine;

public class PlayAtSource : PlayableComponent
{
    [SerializeField] Vector3 offset = Vector3.zero;
    new ParticleSystem particleSystem;
    override public void Play(Effect effect)
    {
        var instance = Instantiate(gameObject, effect.Source + offset, Quaternion.identity);
        Debug.Log("Play at source  effect at : " + effect.Source);
    }
    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<DestroyWhenParticleSystemIsDead>();
    }
}