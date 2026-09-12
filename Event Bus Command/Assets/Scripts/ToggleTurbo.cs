using Chapter.EventBus;

public class ToggleTurbo : Command
{
    private MotorBikeController _controller;
    
    public ToggleTurbo(MotorBikeController controller)
    {
        _controller = controller;
    }

    public override void Execute()
    {
        _controller.ToggleTurbo();
    }
}
