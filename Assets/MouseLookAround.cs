using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLookAround : MonoBehaviour
{
    float rotationX = 0f;
    float rotationY = 0f;

    public float sensitivity = 15f;
    public float minYRotation = -90f; // Batas minimum rotasi pada sumbu Y
    public float maxYRotation = 90f;  // Batas maksimum rotasi pada sumbu Y

    void Update()
    {
        rotationY += Input.GetAxis("Mouse X") * sensitivity;
        rotationX -= Input.GetAxis("Mouse Y") * sensitivity; // Perhatikan penggunaan minus untuk mengurangi rotasi

        // Batasi rotasi pada sumbu Y
        rotationX = Mathf.Clamp(rotationX, minYRotation, maxYRotation);

        transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);
    }
}
