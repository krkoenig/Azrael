using UnityEngine;
using System.Collections;

public class QuickCameraControls : MonoBehaviour
{

    public float speed = 5.0f;

    private Camera cam;

    // Use this for initialization
    void Start()
    {
        cam = gameObject.GetComponent<Camera>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal") * speed;
        float y = Input.GetAxis("Vertical") * speed;

        Vector3 deltaPos = new Vector3(x, y, 0);
        deltaPos = gameObject.transform.rotation * deltaPos;

        gameObject.transform.position += deltaPos;

        cam.orthographicSize -= Input.GetAxis("Mouse ScrollWheel");
    }
}
