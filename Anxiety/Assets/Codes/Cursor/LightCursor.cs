using UnityEngine;
public class LightCursor : MonoBehaviour
{
    [Header("Pointer")]
    public Camera mainCam = null;
    public Transform player = null;
    float x = 0f;
    float y = 0f;
    [SerializeField] float z = 40f;
    Vector3 mousePos = new Vector3(0f, 0f, 0f);
    Vector3 worldPos = new Vector3(0f, 0f, 0f);
    [Header("Constraint")]
    public float leftXClamp = -164f;
    public float rightXClamp = -155f;
    public float downYClamp = 10f;
    public float upYClamp = 12.8f;
    void Update()
    {
        z = player.position.z + 0.5f;
        mousePos = Input.mousePosition;
        mousePos.z = z;
        worldPos = mainCam.ScreenToWorldPoint(mousePos);
        x = Mathf.Clamp(worldPos.x, leftXClamp, rightXClamp);
        y = Mathf.Clamp(worldPos.y, downYClamp, upYClamp);
        transform.position = new Vector3(x, y, z);
    }
}