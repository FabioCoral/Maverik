using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AviaoVoar : MonoBehaviour
{
    [SerializeField] private float flySpeed = 10;
    [SerializeField] private float yawAmount = 120;

    private float yaw;


    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * flySpeed * Time.deltaTime;

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticallInput = Input.GetAxis("Vertical");

        yaw = horizontalInput * yawAmount * Time.deltaTime;
        float pitch = Mathf.Lerp(a: 0, b: 120, t: Mathf.Abs(verticallInput)) * Mathf.Sign(verticallInput);
        float roll = Mathf.Lerp(a: 0, b: 80, t: Mathf.Abs(horizontalInput)) * Mathf.Sign(horizontalInput);

        transform.localRotation = Quaternion.Euler(Vector3.up * yaw + Vector3.right * pitch + Vector3.forward * roll);


    }
}
