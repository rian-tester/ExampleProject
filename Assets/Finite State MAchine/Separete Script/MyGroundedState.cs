using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGroundedState : MovementState
{
    public void Jump (MovementContext context)
    {
        context.SetState(new MyInAirState());
    }
    public void Fall(MovementContext context)
    {
        context.SetState(new MyInAirState());
    }
    public void Land(MovementContext context)
    {
        throw new System.NotImplementedException();
    }
    public void Crouch (MovementContext context)
    {
        context.SetState(new MyCrouchingState());
    }
}
