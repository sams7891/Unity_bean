using TMPro;
using UnityEngine;

public class destroyObjects : MonoBehaviour
{
    SFXScript sfx;
    public TMP_Text counterText;
    private int destroyedDonuts = 0;

    private void Start()
    {
        sfx = FindFirstObjectByType<SFXScript>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Donut"))
        {
            Destroy(collision.gameObject);
            destroyedDonuts++;
            sfx.PlaySFX(0);
            counterText.text = "Donuts destroyed: " + destroyedDonuts;
        }
    }

}
