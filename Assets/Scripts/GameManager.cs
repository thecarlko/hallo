
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject spawner = null;

    private int spawnCount = 10; 

    void Start() {
        Transform transform = spawner.GetComponent<Transform>(); 
        Debug.Log(transform.position.x);
    }
}
