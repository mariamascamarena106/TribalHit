using Unity.VisualScripting;
using UnityEngine;

public class player : MonoBehaviour
{

    [SerializeField] private float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        float horizontalInput = Input.GetAxis("horizontal");
        transform.position += Vector3.right * horizontalInput * speed * Time.deltaTime;
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        Debug.Log("aaaaaaaaa");


        if (collision.gameObject.CompareTag("fruit"))
        {
            Debug.Log("Collision");

            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();

            rb.linearVelocityY = 0f;

            rb.AddForce(Vector3.up * 10f, ForceMode2D.Impulse);
        }


    }

    


}
