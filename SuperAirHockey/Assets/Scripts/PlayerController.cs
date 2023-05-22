using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Alteruna;

public class PlayerController : MonoBehaviour
{
    private Vector3 worldPosition;
    private Vector3 mousePos;

    [SerializeField] private Transform gameBoard;
    
    private Plane plane;

    // Start is called before the first frame update
    void Start()
    {
        plane = new Plane(gameBoard.up, transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float distance;

        if (plane.Raycast(ray, out distance))
        {
            worldPosition = ray.GetPoint(distance);
            transform.position = new Vector3(worldPosition.x, transform.position.y, worldPosition.z);
        }

    }
}
