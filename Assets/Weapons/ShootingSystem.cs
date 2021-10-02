using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.BaseAtoms;
using System.Linq;
public class ShootingSystem : MonoBehaviour
{

    [SerializeField] HitEventReference onHit;
    [SerializeField] ShootEventReference onShot;
    void OnDestroy()
    {
        onShot.Event.Unregister(OnShoot);
    }
    // Start is called before the first frame update
    void Awake()
    {
        onShot.Event.Register(OnShoot);

    }

    void OnShoot(Shoot shoot)
    {
        RaycastHit[] hits = Physics.RaycastAll(shoot.position, shoot.direction, shoot.range);
        foreach (var hit in hits.OrderBy((h) => h.distance))
        {
            if (!hit.collider.isTrigger)
            {
                var hitEvent = new Hit(shoot, hit.collider.gameObject.GetInstanceID().ToString(), hit.point);
                onHit.Event.Raise(hitEvent);
                return;
            }

        }
    }
}
