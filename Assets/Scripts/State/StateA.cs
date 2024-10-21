using UnityEngine;

public class StateA : IState
{
    public void TransferStateA(StateManager state)
    {
        Debug.Log("A 상태입니다.");
        state.ChangeState(this);
    }
    public void TransferStateB(StateManager state)
    {
        Debug.Log("B 상태로 전환합니다.");
        state.ChangeState(new StateB());
    }
}
