using UnityEngine;

public class PortalSystem : MonoBehaviour
{
    PortalManager portalManager;

    //0:¾Õ, 1:µÚ, 2:¿Þ, 3:¿À

    void Start()
    {
    }

    void Update()
    {
        if (portalManager == null && PortalManager.instance != null)
        {
            portalManager = PortalManager.instance;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            portalManager.PortalEffectImage.gameObject.SetActive(true);
            portalManager.PlayerTransform.transform.localPosition = portalManager.PlayerTpSpotTransform.position;
            portalManager.MainCameraTransform.transform.localPosition = portalManager.MainCameraTpSpotTransform.position;
        }
    }
}
