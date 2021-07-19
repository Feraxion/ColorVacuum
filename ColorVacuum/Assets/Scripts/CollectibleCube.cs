using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class CollectibleCube : MonoBehaviour
{
    public bool isMove;
    public Transform targetPos;
    
    // Start is called before the first frame update
    void Start()
    {
        targetPos = GameObject.FindGameObjectWithTag("Vacuum").transform;
        isMove = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isMove)
        {
            gameObject.transform.DOMove(targetPos.position, 1);
            gameObject.transform.DOScale(Vector3.zero, 1.5f);
            gameObject.transform.DORotate(new Vector3(350,360,306),1);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("GoToVacuum"))
        {
            isMove = true;
        }

        if (other.gameObject.CompareTag("Vacuum"))
        {
            Destroy(this.gameObject);
        }
    }
}
