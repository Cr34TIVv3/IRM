using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallInside : MonoBehaviour
{
    public GameObject ball;
    public GameObject barrel;
    public float delta;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 ballPosition = ball.transform.position;
        Vector3 barrelPosition = barrel.transform.position;

        

        if (
            ballPosition.x > barrelPosition.x - delta && ballPosition.x < barrelPosition.x + delta &&
            ballPosition.y < barrelPosition.y + delta/2 &&
            ballPosition.z > barrelPosition.z - delta && ballPosition.z < barrelPosition.z + delta
           )
        {
            Material barrelMaterial = Resources.Load<Material>("Grass");
            MeshRenderer meshRenderer = barrel.GetComponent<MeshRenderer>();
            meshRenderer.material = barrelMaterial;
        }
        //Debug.Log(ballPosition.x > barrelPosition.x - delta);
        //Debug.Log(ballPosition.x < barrelPosition.x + delta);
    }
}
