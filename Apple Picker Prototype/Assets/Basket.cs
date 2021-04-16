using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    void Update()
    {
        // Get the current screen position of the mouse from Input
        Vector3 mousePos2D = Input.mousePosition;

        // The Camera's Z postiion sets how far to push the mouse into 3D
        // if, for example, the camera is at -10 z, we'll set it to 10 here,
        // and this will counteract the Camera.main.ScreenToWorldPoint below
        // so that our final z is zero
        mousePos2D.z = -Camera.main.transform.position.z;

        // Convert the point form 2D screen into 3D world space
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

        // Move the x position of this Basket to the x position of the Mouse
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
    }

    private void OnCollisionEnter(Collision coll)
    {
        // Find out what hit the basket
        GameObject collideWith = coll.gameObject;
        if (collideWith.tag == "Apple")
        {
            Destroy(collideWith);
        }
    }
}
