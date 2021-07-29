using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using Random = System.Random;

public class CollectibleCube : MonoBehaviour
{
    public bool isMove;
    public Transform targetPos;
    private bool isOnce;
    private Transform goPos;
    //private GameObject parentGO;

    //public float speed;
    
    
    // Start is called before the first frame update
    void Start()
    {
        goPos = gameObject.transform;
        targetPos = GameObject.FindGameObjectWithTag("Vacuum").transform;
        //parentGO = GameObject.FindGameObjectWithTag("parentGO");
        isMove = false;
       // speed = 10;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isMove)
        {
            Move();

        }
    }

    void Move()
    {
        //targetPos.position += new Vector3(targetPos.position.x,targetPos.position.y,targetPos.position.z);
        goPos.DOMove(targetPos.position, 1f);
        goPos.DOScale(Vector3.zero, 1f);
        goPos.DORotate(new Vector3(350,360,306),1);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("GoToVacuum") && !isOnce)
        {
            isOnce = true;
            isMove = true;
            //Move();
        }

        if (other.gameObject.CompareTag("Vacuum"))
        {
            
            //Destroy(this.gameObject);
            //int random = UnityEngine.Random.Range(0, 11);
           // if (random == 0)
           // {
                gameObject.SetActive(false);
                //gameObject.transform.SetParent(parentGO.transform);
               // gameObject.transform.SetParent();

           // }
            // else
            // {
            //     //gameObject.SetActive(false);
            //     Destroy(gameObject);
            //
            // }

            //gameObject.transform.position = new Vector3(123, 123, 123);

        }
    }
}
