public class StateManager
{
    private IState state;
    public StateManager()
    {
        state = new StateA();//�⺻ ����       
    }
    //���� ��ȯ
    public void ChangeState(IState state)
    {
        this.state = state;
    }
    //���� ����
    public void StateA()
    {
        state.TransferStateA(this);
    }
    public void StateB()
    {
        state.TransferStateB(this);
    }
}
