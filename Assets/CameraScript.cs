using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private float timer = 0f;

    [SerializeField] public List<GameObject> cameras;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 1f)
        {
            cameras[1].SetActive(true);
            cameras[0].SetActive(false);
        }

        if (timer >= 3f)
        {
            cameras[2].SetActive(true);
            cameras[1].SetActive(false);
        }

        if (timer >= 5f)
        {
            cameras[3].SetActive(true);
            cameras[2].SetActive(false);
        }

    }
}
