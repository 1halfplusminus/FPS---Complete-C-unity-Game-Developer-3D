using UnityEngine;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UniRx;

[CreateAssetMenu(fileName = "CursorManager", menuName = "Zombie Runner/CursorManager", order = 0)]
public class CursorManager : ScriptableObject
{
    [SerializeField] BoolVariable visible;

    [SerializeField] BoolVariable inGame;


    void OnAwake()
    {
        visible.Changed.Register(Visible);
        Init();
    }
    void OnEnable()
    {
        Init();
    }
    void OnDisable()
    {
        CleanUp();
    }
    void Init()
    {
        visible.Changed.Register(Visible);
        inGame.Changed.Register(HideCursorInGame);
        Observable.IntervalFrame(60).Subscribe((s) =>
          {
              if (Cursor.visible && inGame.Value == true)
              {
                  HideCursorInGame(inGame.Value);
              }
          });

    }

    void HideCursorInGame(bool inGame)
    {
        Debug.Log("Hide Cursor in Game");

        if (inGame)
        {
            HideCursor();
            Lock();
        }
    }
    void CleanUp()
    {
        inGame.Changed.Unregister(HideCursorInGame);
        visible.Changed.Unregister(Visible);
    }
    public void Lock()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void UnLock()
    {
        Cursor.lockState = CursorLockMode.None;
    }
    public void HideCursor()
    {
        Debug.Log("Hide cursor");
        visible.SetValue(false, true);
    }
    public void ShowCursor()
    {
        visible.SetValue(true, true);
    }
    void Visible(bool v)
    {
        Debug.Log("Change cursor visibility to: " + v);
        Cursor.visible = v;
    }
}