using NUnit.Framework;
using Unity.VisualScripting;
using UnityEngine;
using System.Collections.Generic;
using Unity.Android.Gradle.Manifest;
using TMPro;
using System.Collections;
public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject apple;
    private float timer;
    List<GameObject> appleList = new List<GameObject>();
    [SerializeField] private float gravity;
    [SerializeField] private Transform PlayerTransform;
    private int score;
    List<GameObject> appleListToRemove = new List<GameObject>();
    [SerializeField] private TMP_Text scoreText;
    void Start()
    {

        timer = 0f;

        InvokeRepeating(nameof(GenerarManzana), 0.5f, 3f);
        StartCoroutine(nameof(GenerarManzana));

    }

    private IEnumerator GenerarManzana()
    {

        GameObject newApple = Instantiate(apple);
        newApple.transform.position = new Vector3((Random.Range(-4f, 3.5f)), 5f, 5f);
        timer = 0f;

        appleList.Add(newApple);

        yield return new WaitForSeconds(5);

        Debug.Log("yasta");
    }



    void Update()
    {
        /*
        timer += Time.deltaTime;

        if (timer > 1.5f)
        {
            GameObject newApple = Instantiate(apple);
            newApple.transform.position = new Vector3((Random.Range(-4f, 3.5f)), 5f, 5f);
            timer = 0f;

            appleList.Add(newApple);

        }
        */
        foreach(GameObject apple in appleList)
        {
            apple.transform.position += Vector3.down * gravity * Time.deltaTime;
            float distancia = Vector3.Distance(apple.transform.position, PlayerTransform.position);
            if (distancia < 1f)
            {
                Debug.Log("Ñam");
                appleListToRemove.Add(apple);

            }
           
        }
        foreach (GameObject apple in appleListToRemove)
        {
            appleList.Remove(apple);
            Destroy(apple);
        }



    }
}
