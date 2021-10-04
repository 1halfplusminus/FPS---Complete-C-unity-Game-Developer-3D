using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UnityAtoms.BaseAtoms;
using System;
using System.Linq;
public class EnableCanvasRendererWhenHit : MonoBehaviour
{
    [SerializeField] CanvasRenderer canvasRenderer;

    [SerializeField] HitEventReference onHit;

    [SerializeField] List<EntityReference> hitTargets;

    [SerializeField] FloatReference duration;
    // Start is called before the first frame update
    void Start()
    {

        canvasRenderer.gameObject.SetActive(false);
        Debug.Assert(canvasRenderer != null, "canvasRenderer should not be null");
        onHit.Event
        .Observe()
        .TakeUntilDisable(gameObject)
        .Subscribe((h) =>
        {
            if (hitTargets.Select((h) => h.Value.Id).Contains(h.hitted))
            {
                //TODO: Filter hit targets
                Debug.Log(gameObject.name + " Detected hit change ui color");
                canvasRenderer.gameObject.SetActive(true);
                var observable = Observable
                .Timer(TimeSpan.FromSeconds(duration.Value))
                .TakeUntilDisable(gameObject)
                .Take(1).Subscribe((s) =>
                {
                    Debug.Log(gameObject.name + " Reset to base color");

                    canvasRenderer.gameObject.SetActive(false);
                });
            }
        });
    }

}
