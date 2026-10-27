using Unity.VisualScripting;
using UnityEngine;

public class Payerscript : MonoBehaviour
{
    [SerializeField] private float speed;

    void Start()
    {

    }

    void Update()
    {
        //Meter movimiento derecha.

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= Vector3.right * speed * Time.deltaTime;
        }



    }
}
