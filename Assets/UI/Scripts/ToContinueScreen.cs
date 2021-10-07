using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UniRx;
public class ToContinueScreen : MonoBehaviour
{
    [SerializeField] Canvas canvas;

    [SerializeField] ColliderEventReference onTrigger;

    [SerializeField] GameManager gameManager;
    [SerializeField] CursorManager cursorManager;

    // Start is called before the first frame update
    void Start()
    {
        canvas.enabled = false;
        onTrigger
        .Event
        .Observe()
        .TakeUntilDestroy(this)
        .Subscribe((c) =>
        {
            Debug.Log("Trigger To Continue");
            ToContinue();
        });
    }

    // Update is called once per frame
    void ToContinue()
    {
        canvas.enabled = true;
        cursorManager.UnLock();
        cursorManager.ShowCursor();
        gameManager.Pause();
    }
}
