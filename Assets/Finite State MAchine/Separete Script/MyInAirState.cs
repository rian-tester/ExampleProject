using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyInAirState : MovementState
{
    public void Jump(MovementContext context)
    {
        throw new System.NotImplementedException();
    }
    public void Fall(MovementContext context)
    {
        throw new System.NotImplementedException();
    }
    public void Land(MovementContext context)
    {
        context.SetState(new MyGroundedState());
    }
    public void Crouch(MovementContext context)
    {
        throw new System.NotImplementedException();
    }
}
