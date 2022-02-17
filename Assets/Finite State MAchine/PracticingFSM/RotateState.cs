using UnityEngine;

public class RotateState : BaseState
{
    public void Moving(StateContext context)
    {
        context.SetState(new MoveState());
    }

    public void Stopping(StateContext context)
    {
        context.SetState(new IdleState());
    }

    public void Turning(StateContext context)
    {
        //
    }
}
