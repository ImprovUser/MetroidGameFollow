public class PlayerStates 
{
    public enum State
    {
        Idle, //default value, idle state is chien first as an init
        Run,
        Jump,
        DoubleJump,
        WallJump,
        WallSlide,
        Dash,
        Crouch,
        Ladders,
        Ignore
    }
}
