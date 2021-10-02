using UnityEngine;
using UniRx;
public class DestroyWhenParticleSystemIsDead : MonoBehaviour
{
    private void Start()
    {
        var particleSystem = GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {
            particleSystem.ObserveEveryValueChanged((p) => p.IsAlive())
                    .TakeUntilDestroy(gameObject)
                    .Where((p) => !p).Subscribe((p) =>
                    {
                        Destroy(gameObject);
                    });
        }

    }
}