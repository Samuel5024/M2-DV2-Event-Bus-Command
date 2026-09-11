using Chapter.EventBus;

public class ToggleTurbo
{
    private BikeController _controller;
    
    public ToggleTurbo(BikeController controller)
    {
        _controller = controller;
    }

    public override void Execute()
    {
        _controller.ToggleTubo();
    }
}
