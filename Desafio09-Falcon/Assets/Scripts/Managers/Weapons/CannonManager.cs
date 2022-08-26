using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonManager : MonoBehaviour
{
    [SerializeField] private Transform shootPoint;
    [SerializeField] private Transform EndPoint;
    [SerializeField] [Range(1f, 100f)] private float rayDistance = 50;

    [SerializeField] private GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CannonRaycast();
    }

    private void CannonRaycast()
    {
        RaycastHit hit;
        if (Physics.Raycast(shootPoint.position, shootPoint.transform.TransformDirection(Vector3.forward), out hit, rayDistance))
        {
            Debug.Log("Collision");
            Instantiate(bullet, shootPoint.transform.position, bullet.transform.rotation);
            /*
            if (hit.transform.CompareTag("Player"))
            {
                Debug.Log("Collision");
            }*/
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.black;
        Vector3 direction = shootPoint.transform.TransformDirection(Vector3.forward) * rayDistance;
        Gizmos.DrawLine(shootPoint.position, direction);
    }
}
