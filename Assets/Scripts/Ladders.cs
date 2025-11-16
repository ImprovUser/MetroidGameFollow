using UnityEngine;

public class Ladders : MonoBehaviour
{
    private LadderAbility laddersAbility;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        laddersAbility=collision.GetComponent<LadderAbility>();

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(laddersAbility!=null)
        {
            if (laddersAbility.isPermitted)
                laddersAbility.canGoOnLadder = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(laddersAbility!= null)
        {
            if(laddersAbility.isPermitted)
                laddersAbility.canGoOnLadder = false;
        }
    }
}
