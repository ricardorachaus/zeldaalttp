using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public GameObject player;
    public float upperBound;
    public float lowerBound;
    public float rightBound;
    public float leftBound;

    private Vector3 offset;

    void Start() {
        offset = transform.position - player.transform.position;
    }

    void LateUpdate() {
        var newPosition = player.transform.position + offset;
        var position = transform.position;
        var horizontalBounds = newPosition.x < rightBound &&
                               newPosition.x > leftBound;
        var verticalBounds = newPosition.y < upperBound &&
                             newPosition.y > lowerBound;

        if (horizontalBounds) {
            position.x = newPosition.x;
        } 

        if (verticalBounds) {
            position.y = newPosition.y;
        }

        transform.position = position;
    }

}
