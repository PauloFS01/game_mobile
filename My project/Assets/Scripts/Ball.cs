using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody RB;
    public float JumpForce;
    public GameObject SplashPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        RB.velocity = new Vector3(0f, JumpForce, 0f);

        GameObject splash = Instantiate(SplashPrefab, transform.position + new Vector3(0f, -0.2f, 0f), Quaternion.Euler(90, 0, 0));
        splash.transform.SetParent(collision.gameObject.transform);

        string materialName = collision.gameObject.GetComponent<MeshRenderer>().material.name;
        // Debug.Log(materialName);

        if(materialName == "PlatformSafe (Instance)")
        {
            // continue
        }
        else if(materialName == "PlatformDanger (Instance)")
        {
            //game over
        }
        else if(materialName == "LastRing (Instance)")
        {
            // level passed
        }
    }
}
