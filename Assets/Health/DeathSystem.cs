using UnityAtoms.BaseAtoms;
using UnityEngine;

[CreateAssetMenu(fileName = "DeathSystem", menuName = "Zombie Runner/DeathSystem", order = 0)]
public class DeathSystem : ScriptableObject
{
    [SerializeField] StringEvent onPlayerDeath;

    [SerializeField] VoidEvent onGameOver;
    void Init()
    {
        Debug.Log("Death System Awake");
        if (onPlayerDeath != null)
        {
            onPlayerDeath.Register(OnPlayerDeath);
        }

    }
    void CleanUp()
    {
        onPlayerDeath.Unregister(OnPlayerDeath);
    }
    void OnDisable()
    {
        CleanUp();
    }
    void OnDestroy()
    {
        CleanUp();
    }
    void OnEnable()
    {
        Init();
    }
    void OnPlayerDeath(string playerId)
    {
        Debug.Log("Player is dead: " + playerId);
        onGameOver.Raise();
    }
}