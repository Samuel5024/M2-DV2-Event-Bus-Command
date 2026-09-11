using Chapter.EventBus;

public class ToggleTurbo : Command
{
    private BikeController1 _controller1;
    
    public ToggleTurbo(BikeController controller1)
    {
        _controller1 = controller1;
    }

    public override void Execute()
    {
        _controller1.ToggleTurbo();
    }
}
