public class StateManager
{
    private IState state;
    public StateManager()
    {
        state = new StateA();//기본 상태       
    }
    //상태 전환
    public void ChangeState(IState state)
    {
        this.state = state;
    }
    //상태 설정
    public void StateA()
    {
        state.TransferStateA(this);
    }
    public void StateB()
    {
        state.TransferStateB(this);
    }
}
