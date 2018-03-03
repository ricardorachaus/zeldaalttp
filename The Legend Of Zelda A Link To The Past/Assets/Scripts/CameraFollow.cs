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
        var horizontalBounds = newPosition.x < rightBound &&
                               newPosition.x > leftBound;
        var verticalBounds = newPosition.y < upperBound &&
                             newPosition.y > lowerBound;

        if (horizontalBounds && verticalBounds) {
            transform.position = newPosition;
        }
    }

}
