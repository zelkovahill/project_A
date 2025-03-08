using UnityEngine;

public class CommandInput : MonoBehaviour
{
    public Vector2 moveInput;

    public KeyCode forwardKey = KeyCode.W;
    public KeyCode backwardKey = KeyCode.S;
    public KeyCode leftKey = KeyCode.A;
    public KeyCode rightKey = KeyCode.D;

    public KeyCode undoKey = KeyCode.Z;
    public KeyCode redoKey = KeyCode.X;

    private Actor _actor;

    private void Awake()
    {
        _actor = GetComponent<Actor>();
    }

    private void Update()
    {
        MoveInput();
        HandleUndoRedo();
    }

    private void MoveInput()
    {
        moveInput = Vector2.zero;

        if (Input.GetKeyDown(forwardKey))
        {
            moveInput.y = 1;
        }
        else if (Input.GetKeyDown(backwardKey))
        {
            moveInput.y = -1;
        }

        if (Input.GetKeyDown(leftKey))
        {
            moveInput.x = -1;
        }
        else if (Input.GetKeyDown(rightKey))
        {
            moveInput.x = 1;
        }

        if (moveInput != Vector2.zero)
        {
            CommandInvoker.ExecuteCommand(new MoveCommand(_actor, moveInput));
        }
    }

    private void HandleUndoRedo()
    {
        if (Input.GetKeyDown(undoKey))
        {
            CommandInvoker.UndoCommand();
        }

        if (Input.GetKeyDown(redoKey))
        {
            CommandInvoker.RedoCommand();
        }
    }
}
