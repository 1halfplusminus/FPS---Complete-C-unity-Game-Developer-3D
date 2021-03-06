using UnityEngine;
using UniRx;
using UnityAtoms.BaseAtoms;
using System.Linq;
public class GameSystem : MonoBehaviour
{

    [SerializeField] CursorManager cursorManager;
    [SerializeField] GameManager gameManager;

    [SerializeField] BoolEventReference onGameOverScreen;

    [SerializeField] BoolEventReference onExitGame;

    void OnGameOverScreen()
    {
        gameManager.InGame = false;
        cursorManager.ShowCursor();
        cursorManager.UnLock();
        gameManager.Pause();
        //TODO: find a better solution
        foreach (IOnGameOver go in Resources.FindObjectsOfTypeAll(typeof(ScriptableObject)).OfType<IOnGameOver>())
        {
            go.OnGameOver();
        }
    }
    void OnDestroy()
    {
        onGameOverScreen.Event.Unregister(OnGameOverScreen);
    }
    void Awake()
    {

        onGameOverScreen.Event.Register(OnGameOverScreen);
        onExitGame.Event.Observe().TakeUntilDisable(this).Subscribe((b) =>
        {
            if (b)
            {
                gameManager.Quit();
            }
        });
    }
    void Start()
    {
        gameManager.UnPause();
        gameManager.InGame = true;
    }
}