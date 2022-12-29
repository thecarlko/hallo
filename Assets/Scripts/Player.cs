

using UnityEngine; 

public class Player : MonoBehaviour
{

    public new GameObject camera = null;

    private int clampLeft = -29;
    private int clampRight = 5;

    private int movementSpeed = 4; 

    void FixedUpdate() {

        // Left movement
        if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) && transform.position.x > clampLeft) {
            transform.Translate(new Vector3(-movementSpeed * Time.deltaTime, 0, 0));
        }

        // Right movement
        if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) && transform.position.x < clampRight) {
            transform.Translate(new Vector3(movementSpeed * Time.deltaTime, 0, 0));
        }



    }
}

