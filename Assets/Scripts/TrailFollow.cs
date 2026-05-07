using UnityEngine;

public class TrailFollow : MonoBehaviour
{
    public Transform player;

    void Update()
    {
        transform.position = player.position + new Vector3(-0.3f, 0f, 0f);
    }
}