using UnityEngine;

public class ObjectCatch : MonoBehaviour
{
    public float sizeIncrease = 0.5f;
    public float massIncrease = 1.0f;

    private Rigidbody2D rb;
    SFXScript sfx;

    private void Start()
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
            sfx.PlaySFX(2);
            Destroy(collision.gameObject);
            transform.localScale += new Vector3(sizeIncrease, sizeIncrease, 0);
            rb.mass += massIncrease;
        }
        else
        {
            Debug.Log("Collided with non-donut object: " + collision.gameObject.name);
        }
    }

}
