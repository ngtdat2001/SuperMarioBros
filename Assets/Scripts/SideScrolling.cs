using UnityEngine;

public class SideScrolling : MonoBehaviour
{
    private Transform player;
    public float height = 6.5f;
    public float undergroundHeight = -9f;

    private void Awake()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    private void LateUpdate()
    {
        Vector3 cameraPosition = transform.position;
        cameraPosition.x = Mathf.Max(cameraPosition.x, player.position.x);
        transform.position = cameraPosition;
    }

    public void SetUnderground(bool IsUnderground){
        Vector3 cameraPosition = transform.position;
        cameraPosition.y = IsUnderground ? undergroundHeight : height;
        transform.position = cameraPosition;
    }
}
