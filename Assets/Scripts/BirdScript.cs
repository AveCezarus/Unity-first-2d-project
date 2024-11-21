using UnityEngine;

public class BirdScript : MonoBehaviour
{
    private Rigidbody2D rb2d;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            rb2d.AddForce(Vector2.up * 300);
        }
       // this.transform.eulerAngles = new Vector3 (0, 0,  rb2d.linearVelocityY);
    }
}
