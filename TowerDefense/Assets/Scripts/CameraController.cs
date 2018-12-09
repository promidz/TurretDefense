using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {



    public float panSpeed = 30f;
    public float panBorderThickness = 10f;

    public float scrollSpeed = 5f;
    public float minY = 10f;
    public float maxY = 80f;

	// Update is called once per frame
	void Update () {

        if (GameManager.gameIsOver)
        {
            this.enabled = false;
            return;
        }

        
        
        //every frame
        
        if (Input.GetKey("w") || Input.mousePosition.y >=Screen.height - panBorderThickness )
        {
            // new Vector3(0f,0f,1f)  = Vector3.forward
            // new Vector3(0f,0f,1f) * panSpeed = Vector3.forward * panSpeed;
            //^ because (0*panspeed =0)x2 and only 1 * panspeed is equal to panSpeed; 
            transform.Translate(Vector3.forward * panSpeed * Time.deltaTime,Space.World);
        }
        if (Input.GetKey("s") || Input.mousePosition.y <= panBorderThickness)
        {
            // new Vector3(0f,0f,1f)  = Vector3.forward
            // new Vector3(0f,0f,1f) * panSpeed = Vector3.forward * panSpeed;
            //^ because (0*panspeed =0)x2 and only 1 * panspeed is equal to panSpeed; 
            transform.Translate(Vector3.back * panSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBorderThickness)
        {
            // new Vector3(0f,0f,1f)  = Vector3.forward
            // new Vector3(0f,0f,1f) * panSpeed = Vector3.forward * panSpeed;
            //^ because (0*panspeed =0)x2 and only 1 * panspeed is equal to panSpeed; 
            transform.Translate(Vector3.right * panSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("a") || Input.mousePosition.x <=panBorderThickness)
        {
            // new Vector3(0f,0f,1f)  = Vector3.forward
            // new Vector3(0f,0f,1f) * panSpeed = Vector3.forward * panSpeed;
            //^ because (0*panspeed =0)x2 and only 1 * panspeed is equal to panSpeed; 
            transform.Translate(Vector3.left * panSpeed * Time.deltaTime, Space.World);
        }

        float scroll =Input.GetAxis("Mouse ScrollWheel");

        Vector3 pos = transform.position;


        pos.y -= scroll *1000* scrollSpeed * Time.deltaTime;
        pos.y = Mathf.Clamp(pos.y, minY, maxY);
        transform.position = pos;

    }
}
