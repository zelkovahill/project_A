using UnityEngine;

public abstract class Command
{
    protected Actor _actor;

    public Command(Actor actor)
    {
        _actor = actor;
    }

    public abstract void Execute();
    public abstract void Undo();
}

public class MoveCommand : Command
{
    private Vector3 _previousPosition;
    private Vector3 _moveDirection;

    public MoveCommand(Actor actor, Vector3 moveDirection) : base(actor)
    {
        _moveDirection = moveDirection;
    }

    public override void Execute()
    {
        _actor.Move(_moveDirection);
    }

    public override void Undo()
    {
        _actor.Move(-_moveDirection);
    }
}
