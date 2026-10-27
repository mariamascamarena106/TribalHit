using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    //TODO
    private GameManager gameManager;

    public void Initialize(GameManager gameManager)
    {
        this.gameManager = gameManager;
    }

    private void OnMouseDown()
    {
        Debug.Log("Adios");

        gameManager.EnemigoDestruido(gameObject);

        Destroy(gameObject);
    }
}