using UnityEngine;

public class StateMachinePattern : MonoBehaviour, StateContext
{
    private BaseState currentState = new IdleState();
    [SerializeField] private Movement movement;

    public void SetState(BaseState newState)
    {
        currentState = newState;
    }

    void Moving() => currentState.Moving(this);
    void Stopping() => currentState.Stopping(this);
    void Turning() => currentState.Turning(this);
    private void OnEnable()
    {
        movement.onMoving += Moving;
        movement.onStill += Stopping;
        movement.onRotating += Turning;
    }
    private void OnDisable()
    {
        movement.onMoving -= Moving;
        movement.onStill -= Stopping;
        movement.onRotating -= Turning;
    }
}
