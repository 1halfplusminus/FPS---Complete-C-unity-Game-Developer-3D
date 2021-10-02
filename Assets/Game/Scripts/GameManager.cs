using UnityEngine;
using UnityAtoms;
using UnityAtoms.BaseAtoms;

[CreateAssetMenu(fileName = "GameManager", menuName = "Zombie Runner/GameManager", order = 0)]
public class GameManager : ScriptableObject
{
    [SerializeField] BoolVariable inGame;

    public bool InGame
    {
        get { return inGame.Value; }
        set { inGame.SetValue(value, true); }
    }

    public void OnEnable()
    {
        InGame = true;
    }
    public void QuitInGame() { InGame = false; }

    // TODO: Better pause handeling
    public void Pause()
    {
        Time.timeScale = 0.05f;

    }

    public void UnPause() { Time.timeScale = 1f; }
}