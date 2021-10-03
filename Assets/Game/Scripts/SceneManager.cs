using UnityEngine;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UniRx;

[CreateAssetMenu(fileName = "SceneManager", menuName = "Zombie Runner/SceneManager", order = 0)]
public class SceneManager : ScriptableObject
{
    [SerializeField] VoidEvent init;
    [SerializeField] VoidEvent reloadCurrentScene;
    [SerializeField] StringVariable currentScene;

    [SerializeField] AtomAction changeToCurrentScene;

    [SerializeField] StringConstant startScene;
    public void ReloadCurrentScene()
    {

        Debug.Log("Realod Scene " + currentScene.Value);
        changeToCurrentScene.Do();
    }
  
    void Awake()
    {
        Init();
    }
    void Init()
    {
        init.Register(OnInit);
        reloadCurrentScene.Register(ReloadCurrentScene);
    }
    void OnInit()
    {
        currentScene.SetValue(startScene.Value);
        Debug.Log("Init Scene Mananer current scene " + currentScene.Value);
    }
    void CleanUp()
    {
        reloadCurrentScene.Unregister(ReloadCurrentScene);
    }

    void OnEnable()
    {

        Init();
    }
    void OnDisable()
    {
        CleanUp();
    }
    void OnDestroy()
    {
        CleanUp();
    }
}