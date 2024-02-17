using UnityEngine;

public class CameraFollowObject : MonoBehaviour
{
    [SerializeField] private Transform objectToFollow;
    private Vector3 thisPos;
    private Vector3 otherPos;

    void Update()
    {
        thisPos = transform.position;
        otherPos = objectToFollow.position;
        
        transform.position = new Vector3(otherPos.x, otherPos.y, thisPos.z);
    }
}
