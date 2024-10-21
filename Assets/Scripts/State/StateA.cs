using UnityEngine;

public class StateA : IState
{
    public void TransferStateA(StateManager state)
    {
        Debug.Log("A �����Դϴ�.");
        state.ChangeState(this);
    }
    public void TransferStateB(StateManager state)
    {
        Debug.Log("B ���·� ��ȯ�մϴ�.");
        state.ChangeState(new StateB());
    }
}
