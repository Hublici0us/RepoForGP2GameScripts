

public class Humanoid : MonoBehaviour
{
    private Animator animator;
    private Rigidbody rb;

    public float speed;

    void Awake()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }
}

public class Enemy : Humanoid
{
   
}

public class Player : Humanoid
{

}