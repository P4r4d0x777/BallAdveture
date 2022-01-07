using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharachterBehaviour : MonoBehaviour
{
    private bool _justJumped = false;
    private bool _forward = false;
    private bool _left = false;
    private bool _right = false;
    private bool _back = false;

    [SerializeField]
    public Rigidbody _rb;

    [SerializeField]
    private float _force;

    [SerializeField]
    private float _jumpForce;

    [SerializeField]
    private Camera MainCamera;


    // Start is called before the first frame update
    private void Start()
    {

    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (_forward)
        {
            _forward = false;
            //_rb.AddForce(new Vector3(-1, 0, 0) * _force * Time.fixedDeltaTime);
            _rb.AddForce(MainCamera.transform.forward * _force * Time.fixedDeltaTime);
        }
        if (_left)
        {
            _left = false;
            _rb.AddForce(-MainCamera.transform.right * _force * Time.fixedDeltaTime);
        }
        if (_back)
        {
            _back = false;
            _rb.AddForce(-MainCamera.transform.forward * _force * Time.fixedDeltaTime);
        }
        if (_right)
        {
            _right = false;
            _rb.AddForce(MainCamera.transform.right * _force * Time.fixedDeltaTime);
        }
        if (_justJumped)
        {
            _justJumped = false;
            _rb.AddForce(Vector3.up * _jumpForce);
        }
    }

    private void Update()
    {
        if (!_justJumped && Input.GetButtonDown("Jump") && Mathf.Abs(_rb.velocity.y) < 0.001F)
        {
            _justJumped = true;
        }
        if (!_forward && Input.GetKey(KeyCode.W))
        {
            _forward = true;
        }
        if (!_left && Input.GetKey(KeyCode.A))
        {
            _left = true;
        }
        if (!_back && Input.GetKey(KeyCode.S))
        {
            _back = true;
        }
        if (!_right && Input.GetKey(KeyCode.D))
        {
            _right = true;
        }
    }
}
