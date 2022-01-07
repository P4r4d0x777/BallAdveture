using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalToBehaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject _character;

    public bool Premission { get; set; }

    [SerializeField]
    private PortalFromBehaviour _portalFrom;
    private void OnTriggerEnter(Collider other)
    {
        if (this.Premission != false)
        {
            _character.transform.position = new Vector3(-25.94f, 0.033f, 13.74f);
            this.Premission = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        this.Premission = true;
        _portalFrom.Premission = false;
    }
}
