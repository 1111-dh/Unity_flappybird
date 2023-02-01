using System.Collections; // using 은 파이썬의 import같은 거임
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour // BirdJump라는 클래스 MonoBehaviour로부터 상속받아 생성
{
    Rigidbody2D rb;
    public float jumpPower; //public을 붙이면 외부에서 jumpPower를 접근할 수 있음 (캡슐화 깨기)
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //마우스 왼쪽버튼: 0, 
        {
            GetComponent<AudioSource>().Play();
            rb.velocity = Vector2.up * jumpPower; // (0,1) * 3 = (0,3)
        }
    }

    private void OnCollisionEnter2D(Collision2D other) { //Colider끼리 부딪혔을때 실행시킴
        if (Score.bestscore < Score.score) {
            Score.bestscore = Score.score;
        }
        SceneManager.LoadScene("GameOverScene");
    }
}
