using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public GameMonitor gameMonitor;
    private void OnTriggerEnter(Collider other)
    {
        gameMonitor.CompleteLevel();
    }
}
