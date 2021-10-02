using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms;
using UnityAtoms.BaseAtoms;

public class GameOverScreen : MonoBehaviour
{
    [SerializeField] DeathSystem deathSystem;
    [SerializeField] VoidEvent onGameOver;

    [SerializeField] BoolReference gameOverScreenVisible;
    // Start is called before the first frame update
    Canvas canvas;
    void OnDisable()
    {
        onGameOver.Unregister(GameOver);
    }
    void Awake()
    {
        onGameOver.Register(GameOver);
    }

    void Start()
    {
        canvas = GetComponent<Canvas>();
        gameOverScreenVisible.Value = false;
        // TODO: active on game start event
        // TODO: use event
        canvas.enabled = gameOverScreenVisible.Value;
    }
    void GameOver()
    {
        // TODO: active on game over
        Debug.Log("GameOver");
        gameOverScreenVisible.Value = true;
        // TODO: use event
        canvas.enabled = gameOverScreenVisible.Value;
    }

}
