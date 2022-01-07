using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Doors
{
    First,
    Second,
    Third,
    Fourth,
};
public class DoorsBehavour : MonoBehaviour
{
    [SerializeField]
    private GameObject _destroyObject;

    [SerializeField]
    private Doors _door;

    private void OnCollisionEnter(Collision collision)
    {
        if (_door != Doors.Third)
            Destroy(_destroyObject);
        else
            Destroy(gameObject);
    }
}
