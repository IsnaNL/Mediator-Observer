using UnityEngine;

public class Mediator : MonoBehaviour
{
    public static  Mediator Instance;
    public GameObject signal;
    public float signalSpeed;
    public bool shouldMove;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }
   public void SendSignal(ObserverNode on1, ObserverNode on2, Vector2 angle)
   {
        Debug.Log("SignalSending");
        signal.SetActive(true);
        signal.transform.position = on1.transform.position;
        signal.GetComponent<Signalmovement>().velocity = angle * signalSpeed;
        on2.GetComponent<CircleCollider2D>().enabled = true;
   }
    public void ResetSignal()
    {
        Debug.Log("SignalReset");
        signal.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
