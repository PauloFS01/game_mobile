using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{
    public Transform Ball;
    private GameManager GM;
    // Start is called before the first frame update
    void Start()
    {
        GM = GameObject.FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y +17 >= Ball.transform.position.y)
        {
            Destroy(gameObject);
            GM.IncreaseGameScore(10);
        }
        
    }
}
