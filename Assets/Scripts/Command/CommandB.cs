public class CommandB : ICommand
{
    private Receiver receiver;
    public CommandB(Receiver receiver)
    {
        this.receiver = receiver;
    }
    public void Execute()
    {
        receiver.CommandB();
    }
}
