using UnityEngine;

public class DoorOpenBehaviour : MonoBehaviour
{
    public OcclusionPortal OcclusionBox;

    void OnTriggerEnter(Collider obj)
    {
        OcclusionBox.open = true;
    }
}
