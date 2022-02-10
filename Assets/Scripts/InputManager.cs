using UnityEngine;

public class InputManager : MonoBehaviour
{
    public float MoveInput { get; private set; }
    public bool jumpInput { get; private set; }
    public bool dashInput { get; private set; }
    public bool dashInputRight { get; private set; }
    public bool dashInputLeft { get; private set; }
    
    [SerializeField] private CommandContainer _commandContainer;

    void Update()
    {
        GetInput();
        SetCommand();
    }

    private void GetInput()
    {
        MoveInput = Input.GetAxis("Horizontal");

        jumpInput = Input.GetKeyDown(KeyCode.Space);
        dashInput = Input.GetKeyDown(KeyCode.LeftShift);
        dashInputRight = Input.GetKeyDown(KeyCode.D);
        dashInputLeft = Input.GetKeyDown(KeyCode.A);
    }

    private void SetCommand()
    {
        _commandContainer.jumpCommand = jumpInput;
        _commandContainer.dashCommand = dashInput;
        _commandContainer.walkCommand = MoveInput;
        _commandContainer.dashRightCommand = dashInputRight;
        _commandContainer.dashLeftCommand = dashInputLeft;
    }    

}
