using UnityEngine;

public class BaseAbility : MonoBehaviour
{
    protected Player player; // protected cuz TO share between parent and child classes

    protected GatherInput linkedInput;
    protected StateMachine linkedStateMachine;
    protected Animator linkedAnimator;
    protected PhysicsControl linkedPhysics;

    public PlayerStates.State thisAbilityState;
    public bool isPermitted = true;

    protected virtual void Start()
    {
        Initialization();
    }

    public virtual void EnterAbility()
    {

    }

    public virtual void ExitAbility()
    {

    }

    public virtual void ProcessAbility()
    {

    }

    public virtual void ProcessFixedAbility()
    {

    }

    public virtual void UpdateAnimator()
    {

    }

    protected virtual void Initialization()
    {
        player=GetComponent<Player>();
        if(player!=null)
        {
            linkedInput = player.gatherInput;
            linkedStateMachine = player.stateMachine;
            linkedPhysics = player.physicsControl;
            linkedAnimator = player.anim;
        }
    }

}
