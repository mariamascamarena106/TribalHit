using UnityEngine;

public class fruit : MonoBehaviour
{
    [SerializeField] private float gravity;
    [SerializeField] private float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        speed += gravity * Time.deltaTime;
        transform.position += Vector3.down * gravity * Time.deltaTime;
        

    }

    
}
