using TMPro;
using UnityEngine;

public class ObjectCatch : MonoBehaviour
{
    public float sizeIncrease = 0.5f;
    public float massIncrease = 1f;
    public TMP_Text counterText;

    public int eatenD = 0;
    private Rigidbody2D rb;
    SFXScript sfx;
    [SerializeField] private playerLife playerLife;



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
            eatenD += 100;
            counterText.text = "Points:\n" + eatenD;

        }
        else if (collision.CompareTag("Enemy")) {
            sfx.PlaySFX(5);
            playerLife.removeLife();
            Destroy(collision.gameObject);

           
        }
    }

}
