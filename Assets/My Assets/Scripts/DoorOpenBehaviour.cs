using System;
using UnityEngine;

public class DoorOpenBehaviour : MonoBehaviour
{
    public GameObject OcclusionDoor;
    void Start()
    {
        OcclusionDoor.GetComponent<OcclusionPortal>().open = false;
    }

    void OnTriggerEnter(Collider obj)
    {
        if (obj.tag == "MainCamera" || obj.gameObject.tag == "Player")
            OcclusionDoor.GetComponent<OcclusionPortal>().open = true;
    }

    void OnTriggerExit(Collider obj)
    {
        if (obj.gameObject.tag == "MainCamera" || obj.gameObject.tag == "Player")
            OcclusionDoor.GetComponent<OcclusionPortal>().open = false;
    }
}
