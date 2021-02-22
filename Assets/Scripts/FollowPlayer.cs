using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform playerLocation;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = playerLocation.position + offset;
    }
}
