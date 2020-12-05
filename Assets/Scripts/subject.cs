using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class subject : MonoBehaviour
{
    public List<ObserverNode> _observers = new List<ObserverNode>();
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(" nodes/observers set" + " : " + _observers.Count);
    }
    void RemoveObserver(ObserverNode on)
    {
        _observers.Remove(on);
    }
    void CallObserverAction(ObserverNode on1, ObserverNode on2)
    {
        Debug.Log("Nodes/Observers called" );
        Vector2 signalangle = new Vector2(on2.transform.position.x - on1.transform.position.x, on2.transform.position.y - on1.transform.position.y).normalized;
        Debug.Log("signal Angle Set");
        Mediator.Instance.SendSignal(on1, on2, signalangle);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(" Space Clicked");

            ObserverNode on1 = _observers[Random.Range(0, 4)];
            ObserverNode on2 = _observers[Random.Range(0, 4)];
           while(on1 == on2)
            {
                on2 = _observers[Random.Range(0, 4)];
            }
           CallObserverAction(on1, on2);
            
        }
    }
   
}

