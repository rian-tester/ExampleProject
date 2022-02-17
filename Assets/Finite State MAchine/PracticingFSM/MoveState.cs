using UnityEngine;

public class MoveState : BaseState
{
    public void Moving(StateContext context)
    {
        //
    }

    public void Stopping(StateContext context)
    {
        context.SetState(new IdleState());
    }

    public void Turning(StateContext context)
    {
        context.SetState(new RotateState());
    }
}
