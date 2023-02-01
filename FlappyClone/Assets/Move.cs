using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame -> 한 프레임 당 한번씩 실행하는 loop
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime; //Vector3.left -> (-1,0,0)
        //Time.deltaTime -> 기기의 성능에 따라 프레임이 달라서 성능이 달라지는 경우를 막기 위함.
    }
}
