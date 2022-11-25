using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCoins : MonoBehaviour
{
    Vector3 rotatecoin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotatecoin = new Vector3(0, 0 , 45);
        transform.Rotate(rotatecoin * Time.deltaTime);
    }
}
