using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
        public Rigidbody rb;
        public float Speed = 800f;
        public float sidewaysMovement = 300f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, Speed * Time.deltaTime);

        if (Input.GetKey("d")){
            rb.AddForce(sidewaysMovement * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a")){
            rb.AddForce(-sidewaysMovement * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f){
            FindObjectOfType<Gm>().EndGame();
        }
    }
}
