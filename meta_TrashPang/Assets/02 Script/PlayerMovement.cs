using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float yAngle = 90f;
    private PlayerInput input;
    // Start is called before the first frame update
    void Start()
    {
        input = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
    }

    private void Rotate()
    {

        if (input != null)
        {
            if(input.Rrotate)
            {
                transform.Rotate(Vector3.up * yAngle);
            }

            if(input.Lrotate)
            {
                transform.Rotate(Vector3.up * yAngle * -1);
            }

        }

    }
}
