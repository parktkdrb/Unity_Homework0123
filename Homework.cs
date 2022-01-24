using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework : MonoBehaviour
{
    public float move_Speed = 1.0f; // �ӵ� �ʱⰪ
    float x_Speed = 0; // x����� �ӵ�����
    float y_Speed = 0; // y����� �ӵ�����
    bool leftFlag = false; // ������ȯ�� ���� ���� (��, ����)
    public float angle = 0.5f; // �ʱ� ������
    public float maxCount = 50.0f;//�ʱ� ��
    int count = 0; // ī���Ϳ�
    public float speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {

        count = 0; // ī���͸� ����  
    }

    // Update is called once per frame
    void Update()

    {
        x_Speed = 0;
        y_Speed = 0;
        if (Input.GetKey("right"))
        {
            x_Speed = move_Speed;
            leftFlag = false; // �� �Ǵ� ���� ���� ���� 
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
        Debug.Log(count);//count ���� �����ϴ� ���� Ȯ���ϱ� ���� �ڵ�
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

    private void FixedUpdate() // ���ʸ��� ������ ������ �̵�
    {
        this.transform.Translate(x_Speed, y_Speed, 0); // ������, ����, ��, �Ʒ� ������Ʈ �̵�
        this.GetComponent<SpriteRenderer>().flipX = leftFlag; // ������, ���� �������� �̵��� ��������Ʈ ���� ��ȯ.
        
    }

}
