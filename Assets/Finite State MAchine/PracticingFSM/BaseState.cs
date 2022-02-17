using UnityEngine;

public interface BaseState 
{
    void Moving(StateContext context);
    void Turning(StateContext context);
    void Stopping (StateContext context);
}
