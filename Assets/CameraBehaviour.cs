using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    [SerializeField]
    private Transform _objToFollow;

    private Vector3 _deltaPos;

    [SerializeField]
    private float sensitivity = 3f;

    public float headMinY = -40f; // ограничение угла для головы
    public float headMaxY = 30f;

    private float rotationY;
    private void Start()
    {
        _deltaPos = _objToFollow.position - transform.position;
    }
    private void Update()
    {
        transform.position = _objToFollow.position - _deltaPos;

        float rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivity;

        rotationY += Input.GetAxis("Mouse Y") * sensitivity;
        rotationY = Mathf.Clamp(rotationY, headMinY, headMaxY);

        transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
    }
}
