using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Player; //transformdan referans alıyor
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {

        transform.position = Player.position + offset;
        
    }
}
