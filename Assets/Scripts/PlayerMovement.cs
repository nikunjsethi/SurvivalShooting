using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Player")]
    public int playerSpeed;
    public Vector2 mouseTurn;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        mouseTurn.x += Input.GetAxis("Mouse X");
        mouseTurn.y += Input.GetAxis("Mouse Y");
        //transform.localRotation = Quaternion.Euler(-mouseTurn.y, mouseTurn.x, 0);
        rb.rotation= Quaternion.Euler(-mouseTurn.y, mouseTurn.x, 0);
        float hMov = Input.GetAxis("Horizontal");
        float vMov = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(hMov * playerSpeed, 0, vMov * playerSpeed);
    }
}
