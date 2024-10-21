public class Invoker
{
    private ICommand command;
    public void SetCommand(ICommand command)
    {
        this.command = command;
    }
    public void Execute()
    {
        command.Execute();
    }
}
