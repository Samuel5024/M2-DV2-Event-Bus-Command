using Chapter.EventBus;
using UnityEngine;

public class TurnLeft : Command
{
    private MotorBikeController _controller;

    public TurnLeft(MotorBikeController controller)
    {
        _controller = controller;
    }
    public override void Execute()
    {
        _controller.Turn(MotorBikeController.Direction.Left);
    }
}
