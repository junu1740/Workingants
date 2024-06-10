using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public GameObject Door;
    public GameObject Candy;
    public GameObject TextIt;
    public Text Text;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Door.SetActive(false);
        Candy.SetActive(false);
        TextIt.SetActive(true);
        Text.text = $"개미굴로 가져가세요";
        
    }
}
