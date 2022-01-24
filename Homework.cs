using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework : MonoBehaviour
{
    public float move_Speed = 1.0f; // 속도 초기값
    float x_Speed = 0; // x축방향 속도변수
    float y_Speed = 0; // y축방향 속도변수
    bool leftFlag = false; // 방향전환을 위한 변수 (참, 거짓)
    public float angle = 0.5f; // 초기 각도값
    public float maxCount = 50.0f;//초기 빈도
    int count = 0; // 카운터용
    public float speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {

        count = 0; // 카운터를 리셋  
    }

    // Update is called once per frame
    void Update()

    {
        x_Speed = 0;
        y_Speed = 0;
        if (Input.GetKey("right"))
        {
            x_Speed = move_Speed;
            leftFlag = false; // 참 또는 거짓 값을 대입 
        }

        if (Input.GetKey("left"))
        {
            x_Speed = -move_Speed;
            leftFlag = true;
        }

        if (Input.GetKey("up"))
        {
            y_Speed = move_Speed;
        }

        if (Input.GetKey("down"))
        {
            y_Speed = -move_Speed;
        }
        count = count + 1;
        Debug.Log(count);//count 값이 증가하는 것을 확인하기 위한 코드
        if (Input.GetKey("q"))
        {
            this.transform.Rotate(0, 0, -angle);
            count = 0;
            this.transform.Translate(speed, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            this.transform.Rotate(0, 0, angle);
            count = 0;
            this.transform.Translate(speed, 0, 0);
        }
    }

    private void FixedUpdate() // 매초마다 동일한 프레임 이동
    {
        this.transform.Translate(x_Speed, y_Speed, 0); // 오른쪽, 왼쪽, 위, 아래 오브젝트 이동
        this.GetComponent<SpriteRenderer>().flipX = leftFlag; // 오른쪽, 왼쪽 방향으로 이동시 스프라이트 방향 전환.
        
    }

}
