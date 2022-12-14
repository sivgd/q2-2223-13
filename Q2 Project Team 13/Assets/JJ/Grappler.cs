using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grappler : MonoBehaviour
{
    public Camera mainCamera;
    public LineRenderer _lineRenderer;
    public DistanceJoint2D _distanceJoint;
    public bool isAttachable;

    // Start is called before the first frame update
    void Start()
    {
        _distanceJoint.enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);
                if (hit)
                {
                    //Debug.Log(hit.collider.gameObject.tag);
                    if(hit.collider.gameObject.tag == "isAttachable")
                    {
                        //Debug.Log("OK to attach...");
                        Vector2 mousePos = (Vector2)mainCamera.ScreenToWorldPoint(Input.mousePosition);
                        _lineRenderer.SetPosition(0, mousePos);
                        _lineRenderer.SetPosition(1, transform.position);
                        _distanceJoint.connectedAnchor = mousePos;
                        _distanceJoint.enabled = true;
                        _lineRenderer.enabled = true;


                    }

                }
            }
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //Vector2 mousePos = (Vector2)mainCamera.ScreenToWorldPoint(Input.mousePosition);
            //_lineRenderer.SetPosition(0, mousePos);
            //_lineRenderer.SetPosition(1, transform.position);
            //_distanceJoint.connectedAnchor = mousePos;
            //_distanceJoint.enabled = true;
            //_lineRenderer.enabled = true;
        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            _distanceJoint.enabled = false;
            _lineRenderer.enabled = false;
        }
        if (_distanceJoint.enabled)
        {
            _lineRenderer.SetPosition(1, transform.position);
        }
    }
}
