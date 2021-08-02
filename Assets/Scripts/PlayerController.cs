using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private readonly float _speed = 0.005f;
    private Vector2 _startPos;
    float max_z = -5f;
    float min_z = -0.5f;


    private void Update()
    {   

        if (Input.touchCount > 0)
        {
            var touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    _startPos = touch.position;
                    break;

                case TouchPhase.Moved:
                    if (this.transform.position.z < -5)
                    {
                        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, max_z  );
                    }
                    if (this.transform.position.z > -0.5)
                    {
                        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, min_z );
                    }
                    transform.position = new Vector3(transform.position.x,transform.position.y,transform.position.z + touch.deltaPosition.x * _speed);
                    break;
            }
        }
    }


}
