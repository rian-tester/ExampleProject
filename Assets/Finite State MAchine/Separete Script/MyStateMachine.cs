using System.Collections;
using System.Collections.Generic;
using UnityEngine;


   public interface MovementContext
    {
        void SetState(MovementState newState);
    }
    public interface MovementState
    {
        void Jump (MovementContext context);
        void Fall (MovementContext context);
        void Land (MovementContext context);
        void Crouch(MovementContext context);
    }
    public class MyStateMachine : MonoBehaviour, MovementContext
    {
        MovementState currentSate;

        public void Jump() => currentSate.Jump(this);
        public void Fall() => currentSate.Fall(this);
        public void Land () => currentSate.Land(this);
        public void Crouch() => currentSate.Crouch(this);

        void MovementContext.SetState(MovementState newState)
        {
            currentSate = newState;
        }
    }

