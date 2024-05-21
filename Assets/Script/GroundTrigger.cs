using UnityEngine;

public class GroundTrigger : MonoBehaviour
{
    private static GroundTrigger instance;
    public static GroundTrigger Instance
    {
        get { return instance; }
    }

    public Animator anim;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        anim = GetComponent<Animator>();
    }


}
