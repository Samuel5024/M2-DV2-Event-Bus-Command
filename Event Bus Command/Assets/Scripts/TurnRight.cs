using Chapter.EventBus;
using UnityEngine;

public class TurnRight : Command
{
    private MotorBikeController _controller;

    public TurnRight(MotorBikeController controller)
    {
        _controller = controller;
    }

    public override void Execute()
    {
        _controller.Turn(MotorBikeController.Direction.Right);
    }
}
