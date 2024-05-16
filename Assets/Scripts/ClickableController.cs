using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableController : MonoBehaviour
{
    [SerializeField] private Transform point1;
    [SerializeField] private Transform point2;
    [SerializeField] private LineRenderer lineRenderer;
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        lineRenderer.SetPosition(0, point1.position);
        lineRenderer.SetPosition(1, point2.position);
    }
}
