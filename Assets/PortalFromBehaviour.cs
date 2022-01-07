using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PortalFromBehaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject _character;

    public bool Premission { get; set; }

    [SerializeField]
    private PortalToBehaviour _portalTo;
    void Start()
    {
        this.Premission= true;
    }
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (this.Premission != false)
        {
            _character.transform.position = new Vector3(-36.62f, 7.05f, -15.63f);
            this.Premission = false;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        this.Premission = true;
        _portalTo.Premission = false;
    }
}
