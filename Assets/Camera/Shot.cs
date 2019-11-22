using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    // Start is called before the first frame update

    public Vector3 focalpoint;

    public void CutToShot()
    {
        //transform.LookAt(focalpoint);
        Camera.main.transform.localPosition = transform.position;
        Camera.main.transform.localRotation = transform.rotation;
    }

    private void OnDrawGizmosSelected()
    {
        if(!Application.isPlaying)
        {
            CutToShot();
        }
    }
    /*
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, focalpoint);
    }
    */
}
