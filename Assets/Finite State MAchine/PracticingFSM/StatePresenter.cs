using UnityEngine;
using TMPro;
using System;

public class StatePresenter : MonoBehaviour
{
    [SerializeField] StateMachinePattern stateMachine;
    
    [SerializeField] TextMeshProUGUI stateText;
    private void Start()
    {
        stateText.text = $"State : {stateMachine.CurrentState} ";
    }
    private void OnEnable()
    {
        stateMachine.onStateChange += UpdateStateText;
    }
    private void OnDisable()
    {
        stateMachine.onStateChange -= UpdateStateText;
    }
    void UpdateStateText ()
    {
        stateText.text = $"State : {stateMachine.CurrentState} ";
    }
}
