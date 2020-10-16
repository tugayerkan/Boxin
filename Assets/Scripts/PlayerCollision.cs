using UnityEngine;

public class PlayerCollision : MonoBehaviour
{ 

    public PlayerMove movement;
    public GameMonitor GameMonitor;

    private void OnCollisionEnter(Collision collisionInfo)
    {
       if(collisionInfo.collider.tag=="Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameMonitor>().EndGame();

        }
    }
}