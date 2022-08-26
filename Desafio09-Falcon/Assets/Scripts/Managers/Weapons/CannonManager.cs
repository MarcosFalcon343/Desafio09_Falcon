using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonManager : MonoBehaviour
{
    [SerializeField] private Transform shootPoint;
    [SerializeField] [Range(1f, 20f)] private float rayDistance = 10;

    // Start is called before the first frame update
    void Start()
    {
        RaycastHit hit;
        if (Physics.Raycast(shootPoint.position, Vector3.forward, out hit, rayDistance))
        {
            if (hit.transform.CompareTag("Player"))
            {
                Debug.Log("Collision");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
