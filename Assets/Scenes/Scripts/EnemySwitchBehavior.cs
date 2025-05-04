using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySwitchBehavior : MonoBehaviour
{
    public enum STATE
    {
        IDLE,
        AGGROED,
        ATTACKING,
        DEFEATED
    }
    public STATE currentState;
    // Start is called before the first frame update
    void Start()
    {
        if (currentState == STATE.IDLE)
        {
            System.Array values = System.Enum.GetValues(typeof(STATE));
            currentState = (STATE)values.GetValue(Random.Range(0, values.Length));
        }
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentState)
        {
            case STATE.IDLE:
                Debug.Log("il nemico è fermo");
                break;
            case STATE.AGGROED:
                Debug.Log("il nemico insegue il giocatore");
                break;
            case STATE.ATTACKING:
                Debug.Log("il nemico sta attaccando il giocatore");
                break;
            case STATE.DEFEATED:
                Debug.Log("il nemico è sconfitto");
                break;
        }
    }
}
