using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class controls : MonoBehaviour
{
    public Vector2 mousePosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(mousePosition.x, mousePosition.y, 0) * Time.deltaTime );
    }

    void OnMouseMove()
    {
        mousePosition = Mouse.current.position.ReadValue();
    }
}
