using UnityEngine;

public class IdleAbility : BaseAbility
{

    private string idleAnimParameterName = "Idle";
    private int idleParameterInt;

    public override void EnterAbility()
    {
        linkedPhysics.rb.linearVelocityX = 0;
    }
    protected override void Initialization()
    {
        base.Initialization(); //this just calls the inital Initilization function in BaseAbilty class before executing other things in this child class
        idleParameterInt=Animator.StringToHash(idleAnimParameterName);

    }
    public override void ProcessAbility()
    {
       // Debug.Log("this is idle ability");
        if(linkedInput.horizontalInput!=0)
        {
            player.Flip();
            linkedStateMachine.ChangeState(PlayerStates.State.Run);
        }
    }

    public override void UpdateAnimator()
    {
        linkedAnimator.SetBool(idleParameterInt, linkedStateMachine.currentState == PlayerStates.State.Idle);
    }
}





