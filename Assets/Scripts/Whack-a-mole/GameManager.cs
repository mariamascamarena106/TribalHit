using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class GameManager : MonoBehaviour
{
    //TODO

    // Prefab del enemigo que vamos a generar
    [SerializeField] private GameObject enemyPrefab;

    [SerializeField] private float speed;
    // ARRAY:
    // Las posiciones posibles son conocidas y no cambiarán
    // durante la ejecución del juego.
    [SerializeField] private Transform[] spawnPoints;

    // Número de enemigos que queremos generar en cada ronda
    [SerializeField] private int numberOfEnemies = 5;
    // LIST:
    // El número de enemigos vivos sí cambiará durante la partida.
    private List<GameObject> activeEnemies = new List<GameObject>();

    private int score = 0;

    GameObject createdEnemy;
    //Score
    void Start()
    {
        //TODO: Llamamos a la generación de enemigos

        GenerarEnemigos();
    }

    void moverEnemigos(List <GameObject> enemies)
    {
        for(int i = 0; i < enemies.Count; i++)
        {
            if(Random.Range(0,2) == 0)
            {
                enemies[i].transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
            }
            else
            {
                enemies[i].transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
            }
        }

    }
    




    void Update()
    {
        //TODO:  Reiniciamos la ronda pulsando R

        createdEnemy.transform.position += new Vector3(speed, 0f, 0f) * Time.deltaTime;

        if(createdEnemy.transform.position.x > 13f)
        {
            createdEnemy.transform.position = Vector3.zero;
        }

        moverEnemigos(activeEnemies);

    }

    //Generar oleada
    private void GenerarEnemigos()
    {
        //TODO: 
        // Evitamos intentar generar más enemigos
        // que posiciones disponibles.

        // ARRAY auxiliar:
        // Nos permite saber qué posiciones ya hemos utilizado.
        //
        // false = libre
        // true = ocupada
        bool[] ocupados = new bool[spawnPoints.Length];
        // FOR:
        // Sabemos cuántos enemigos queremos generar.
        int randomPosition = Random.Range(0, spawnPoints.Length);
    for (int i = 0; i < numberOfEnemies; i++)
    {
            
            while (ocupados[randomPosition])
            {
                randomPosition = Random.Range(0, spawnPoints.Length);
            }
    
        // Elegimos una posición aleatoria.

        // WHILE:
        // Mientras esa posición ya esté ocupada,
        // buscamos otra.

        // Marcamos esa posición como utilizada.
        ocupados[randomPosition] = true;

        // Creamos el enemigo.
        createdEnemy = Instantiate(
            enemyPrefab,
            spawnPoints[randomPosition].position,
            Quaternion.identity);

        // Guardamos el enemigo en nuestra lista
        // de enemigos actualmente vivos.
        activeEnemies.Add(createdEnemy);


        // Le damos al enemigo una referencia
        // al GameManager.
        EnemyScript eScript = createdEnemy.GetComponent<EnemyScript>();

        eScript.Initialize(this);
    }
    }


    //Si se destruye un enemigo, incrementamos el score

    public void EnemigoDestruido(GameObject enemy)
    {
        //TODO: 
        // Eliminamos la referencia de la lista.

        
        // Cuando la lista esté vacía,

        // hemos terminado la ronda.
        
    }


    //Reiniciar la ronda

    private void ReiniciarEnemigos()
    {
        //TODO: 
        // Primero eliminamos cualquier enemigo
        // que todavía esté vivo.

        // Generamos una nueva oleada.
    }

    // Elminar a todos los enemigos
    private void EliminarEnemigos()
    {
        //TODO: 
        // FOREACH:
        // Queremos hacer la misma operación
        // con todos los enemigos de la lista.

        // Dejamos vacía la lista.

    }
}





