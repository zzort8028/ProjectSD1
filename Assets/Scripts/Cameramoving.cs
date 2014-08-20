using UnityEngine;
using System.Collections;

public class Cameramoving : MonoBehaviour
{

    Vector3 firstPos = Vector3.zero;
    Vector3 secondPos = Vector3.zero;
    Vector3 direction = Vector3.zero;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            firstPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        if (Input.GetMouseButtonUp(0))
        {
            secondPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            direction = firstPos - secondPos;
        }
        if (Input.GetMouseButton(0))
        {
            secondPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            transform.position += new Vector3(firstPos.x - secondPos.x, 0);

            if (transform.position.x > 39f)
                transform.position = new Vector3(39f, transform.position.y, -10);
            else if (transform.position.x < -39f)
                transform.position = new Vector3(-39f, transform.position.y, -10);

        }

        if (direction.x > 0.5f)
        {
            transform.position += new Vector3(direction.x * 0.1f, 0);
            if (transform.position.x > 39f)
                transform.position = new Vector3(39f, transform.position.y, -10);
        }
        else if (direction.x < -0.5f)
        {
            transform.position -= new Vector3(direction.x * -0.1f, 0);
            if (transform.position.x < -39f)
                transform.position = new Vector3(-39f, transform.position.y, -10);
        }

      
    }


}
