using UnityEngine;

public class Mirror : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("1");
            PMove.instance.MirrorCheck();
            Destroy(gameObject);
        }
    }


}



