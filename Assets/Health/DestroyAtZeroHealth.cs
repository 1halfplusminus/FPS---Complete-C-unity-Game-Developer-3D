

using UnityEngine;
using UnityAtoms.BaseAtoms;
public class DestroyAtZeroHealth : MonoBehaviour
{

    [SerializeField] IntEventReference onHealthChanged;


    private void Start()
    {
        onHealthChanged.Event.Register((health) =>
        {
            if (health <= 0)
            {
                Destroy(gameObject);
            }
        });
    }
}