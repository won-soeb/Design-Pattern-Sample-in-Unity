using UnityEngine;

public class StateB : IState
{
    public void TransferStateA(StateManager state)
    {
        Debug.Log("A ���·� ��ȯ�մϴ�.");
        state.ChangeState(new StateA());
    }
    public void TransferStateB(StateManager state)
    {
        Debug.Log("B �����Դϴ�.");
        state.ChangeState(this);
    }
}
