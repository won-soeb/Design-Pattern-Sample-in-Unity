public class CommandA : ICommand
{
    private Receiver receiver;
    public CommandA(Receiver receiver)
    {
        this.receiver = receiver;
    }
    public void Execute()
    {
        receiver.CommandA();
    }
}
