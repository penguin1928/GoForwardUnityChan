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

    //キューブと地面、キューブ同士が衝突した際に実行
    //2つの音声が同時に流れることを防ぐために、地面・キューブともに上に位置するキューブの音声が流れ、
    //下に位置するキューブの音声を流さないように条件付け
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
