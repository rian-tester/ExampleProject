using UnityEngine;

public class IdleState : BaseState
{
    public void Moving(StateContext context)
    {
        context.SetState(new MoveState());
    }

    public void Stopping(StateContext context)
    {
        //
    }

    public void Turning(StateContext context)
    {
        context.SetState(new RotateState());
    }
}
