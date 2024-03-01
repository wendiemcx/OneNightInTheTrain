using System.Collections;
using Cinemachine;
using UnityEngine;

public class SpecialVirtualCameraBehaviour : MonoBehaviour
{
    public Camera mainCamera;
    public Camera specialCamera;
    public CinemachineVirtualCamera virtualCamera;
    public CinemachineImpulseSource cinemachineImpulseSource;

    public float impulseDuration;

    public Vector3 impulseRandomVelocity;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            PlayImpulse();
        }
    }

    public void PlayImpulse()
    {
        StartCoroutine(ImpulseRoutine());
    }

    IEnumerator ImpulseRoutine()
    {
        mainCamera.enabled = false;
        specialCamera.gameObject.SetActive(true);
        yield return null;
        GenerateImpulse();

        yield return new WaitForSeconds(impulseDuration);
        specialCamera.gameObject.SetActive(false);
        mainCamera.enabled = true;

    }

    void GenerateImpulse()
    {
        Vector3 randomizedVelocity = new Vector3(
                    UnityEngine.Random.Range(-impulseRandomVelocity.x, impulseRandomVelocity.x),
                    UnityEngine.Random.Range(-impulseRandomVelocity.y, impulseRandomVelocity.y),
                    UnityEngine.Random.Range(-impulseRandomVelocity.z, impulseRandomVelocity.z));

        cinemachineImpulseSource.GenerateImpulse(specialCamera.transform.TransformDirection(randomizedVelocity));
    }

    void LateUpdate()
    {
        virtualCamera.m_Lens.FieldOfView = mainCamera.fieldOfView;
        virtualCamera.m_Lens.FarClipPlane = mainCamera.farClipPlane;
        virtualCamera.m_Lens.NearClipPlane = mainCamera.nearClipPlane;
    }
}
