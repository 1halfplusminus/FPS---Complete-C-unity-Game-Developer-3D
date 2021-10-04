using UnityAtoms;
using UnityEngine;
using UnityAtoms.BaseAtoms;
using TMPro;
using UniRx;
public class DisplayInt : MonoBehaviour
{
    //TODO: Templating system
    StringReference attribute;
    [SerializeField]
    TMP_Text textField;
    [SerializeField]
    IntReference value;
    void Awake()
    {
        value.GetEvent<IntEvent>().Observe().TakeUntilDisable(this).Subscribe((i) =>
         {
             SetValue(i);
         });
    }
    void Start()
    {
        SetValue(value.Value);
    }
    void SetValue(int value)
    {
        //TODO: Templating system
        textField.text = value.ToString();
    }
}