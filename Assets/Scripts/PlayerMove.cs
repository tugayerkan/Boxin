using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public Rigidbody rb;
    // Start is called before the first frame update

    public float forwardForce = 2000f; //variable içinde tutuldu
    public float sidewaysForward = 500f;
    void Start()
    {
        Debug.Log("Welcome to the game");
    
    }

    // Update is called once per frame
    void FixedUpdate()//fixedupdate unity fizikleri için daha geçerli
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //force kazandırıyor delta ise frame ile eşitliyor
        


        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForward * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForward * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -2f)
        {
            FindObjectOfType<GameMonitor>().EndGame();

        }
    }
    
}
