using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCon : MonoBehaviour
{
    public GameObject Camera;
    public float speed = 100f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal") * speed;
        float v = Input.GetAxisRaw("Vertical") * speed;
        Camera.transform.Rotate(new Vector3(v * Time.deltaTime, 0, 0));
        Camera.transform.Rotate(new Vector3(0, h * Time.deltaTime, 0));
    }
}
