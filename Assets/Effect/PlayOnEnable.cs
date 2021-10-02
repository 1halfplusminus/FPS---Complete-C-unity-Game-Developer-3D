using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;

[ExecuteAlways]
public class PlayOnEnable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var particle = GetComponent<ParticleSystem>();
        this
        .OnEnableAsObservable()
        .TakeUntilDestroy(this)
        .Subscribe((x) =>
            {
                Debug.Log("Play on enable");
                particle.time = 0;
                particle.Play();
            }
        );

        this.OnDisableAsObservable()
        .TakeUntilDestroy(this).Subscribe((x) => particle.Stop());
    }

}
