using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grappler : MonoBehaviour
{
    public Camera mainCamera;
    public LineRenderer _lineRenderer;
    public DistanceJoint2D _distanceJoint;
    public bool isAttachable;
    Animator a;
    // Start is called before the first frame update
    void Start()
    {
        _distanceJoint.enabled = false;
        a = gameObject.GetComponent<Animator>();
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
                        Vector3 mP3 = new Vector3(mousePos.x, mousePos.y, -10);

                        _lineRenderer.SetPosition(0, mP3);
                        Vector3 tP3 = new Vector3(transform.position.x, transform.position.y, -10);
                        _lineRenderer.SetPosition(1, tP3);
                        _distanceJoint.connectedAnchor = mP3;
                        _distanceJoint.enabled = true;
                        _lineRenderer.enabled = true;
                        a.SetBool("Grappled", true);

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
            a.SetBool("Grappled", false);
        }
        if (_distanceJoint.enabled)
        {
            _lineRenderer.SetPosition(1, transform.position);
        }
    }
}
