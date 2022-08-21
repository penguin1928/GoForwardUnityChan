using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private float speed = -12;
    private float deadline = -10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        if (transform.position.x < this.deadline)
        {
            Destroy(gameObject);
        }
    }

    //�L���[�u�ƒn�ʁA�L���[�u���m���Փ˂����ۂɎ��s
    //2�̉����������ɗ���邱�Ƃ�h�����߂ɁA�n�ʁE�L���[�u�Ƃ��ɏ�Ɉʒu����L���[�u�̉���������A
    //���Ɉʒu����L���[�u�̉����𗬂��Ȃ��悤�ɏ����t��
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Cube")
        {
            if (this.gameObject.transform.position.y > collision.gameObject.transform.position.y)
            {
                this.gameObject.GetComponent<AudioSource>().Play();
            }
        }
    }
}
