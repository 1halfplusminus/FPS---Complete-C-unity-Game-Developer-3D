using UnityEngine;
using UniRx;
using UnityAtoms.BaseAtoms;

public class GameSystem : MonoBehaviour
{
    [SerializeField] CursorManager cursorManager;
    [SerializeField] GameManager gameManager;

    [SerializeField] BoolEventReference onGameOverScreen;



    void OnGameOverScreen()
    {
        gameManager.InGame = false;
        cursorManager.ShowCursor();
        cursorManager.UnLock();
        gameManager.Pause();
    }
    void OnDestroy()
    {
        onGameOverScreen.Event.Unregister(OnGameOverScreen);
    }
    void Awake()
    {
        onGameOverScreen.Event.Register(OnGameOverScreen);
    }
    void Start()
    {
        gameManager.UnPause();
        gameManager.InGame = true;
    }
}