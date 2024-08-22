using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAnyGameObjectAfterCertainTime : MonoBehaviour
{
    [SerializeField] float timeToDestroyGameObject;
    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(DestroyGameObjectAfterCertainTime), timeToDestroyGameObject);
    }

    void DestroyGameObjectAfterCertainTime()
    {
        Destroy(gameObject);
    }
}
