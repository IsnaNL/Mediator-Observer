using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObserverNode : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Signal Reached Destination");
        Mediator.Instance.ResetSignal();
        this.GetComponent<CircleCollider2D>().enabled = false;
    }
}
