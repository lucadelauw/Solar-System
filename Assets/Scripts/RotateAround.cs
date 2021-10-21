using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public Transform target; // the target to rotate around
    public int speed; // the speed of rotation

    // Start is called before the first frame update
    void Start()
    {
        if (target == null)
        {
            target = this.gameObject.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(target.transform.position, target.transform.up, speed * Time.deltaTime);
    }
}
