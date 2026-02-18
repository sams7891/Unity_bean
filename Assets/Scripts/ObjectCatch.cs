using UnityEngine;

public class ObjectCatch : MonoBehaviour
{
    public float sizeIncrease = 0.5f;
    public float massIncrease = 1f;
    private Rigidbody2D rb;
    SFXScript sfx;


    void Start()
    {
        sfx = FindFirstObjectByType<SFXScript>();
        rb = GetComponent<Rigidbody2D>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.IsChildOf(transform))
            return;

        if (collision.CompareTag("Donut"))
        {
            sfx.PlaySFX(4);
            Destroy(collision.gameObject);
            transform.localScale += new Vector3(sizeIncrease, sizeIncrease, 0);
            rb.mass += massIncrease;

        }
        else if (collision.CompareTag("Enemy")) {
            sfx.PlaySFX(4);
            Destroy(collision.gameObject);
            transform.localScale += new Vector3(sizeIncrease, sizeIncrease, 0);
            rb.mass += massIncrease;
        }
    }

}
