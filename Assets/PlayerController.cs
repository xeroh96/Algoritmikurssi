using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    public float lookSpeed = 10;
    private Vector3 curLoc;
    private Vector3 prevLoc;

    void Update()
    {
        InputListen();
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(transform.position - prevLoc), Time.fixedDeltaTime * lookSpeed);
    }

    private void InputListen()
    {
        prevLoc = curLoc;
        curLoc = transform.position;

        if (Input.GetKey(KeyCode.A))
            curLoc.x -= 1 * Time.fixedDeltaTime;
        if (Input.GetKey(KeyCode.D))
            curLoc.x += 1 * Time.fixedDeltaTime;
        if (Input.GetKey(KeyCode.W))
            curLoc.z += 1 * Time.fixedDeltaTime;
        if (Input.GetKey(KeyCode.S))
            curLoc.z -= 1 * Time.fixedDeltaTime;
        if (Input.GetKey(KeyCode.R))
            SceneManager.LoadScene("SampleScene");

        transform.position = curLoc;

    }
}
