using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest : MonoBehaviour
{
    public Text quest;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        quest.text = "���̸� ����������!!"; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
