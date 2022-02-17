using UnityEngine;

public class StateMachinePattern : MonoBehaviour, StateContext
{
    private BaseState currentState;
    public void SetState(BaseState newState)
    {
        currentState = newState;
    }

    void Moving() => currentState.Moving(this);
    void Stopping() => currentState.Stopping(this);
    void Turning() => currentState.Turning(this);
}
