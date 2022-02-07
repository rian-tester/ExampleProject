using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCrouchingState : MovementState
{
    public void Jump(MovementContext context)
    {
        context.SetState(new MyGroundedState());
    }
    public void Fall(MovementContext context)
    {
        throw new System.NotImplementedException();
    }
    public void Land(MovementContext context)
    {
        throw new System.NotImplementedException();
    }
    public void Crouch(MovementContext context)
    {
        context.SetState(new MyGroundedState());
    }
}
