using UnityEngine;
using UnityEngine.UI;

public class playerLife : MonoBehaviour
{
    public GameObject[] lifes;
    public GameObject player;
    public Toggle gameToggle;

    [SerializeField]private ObjectCatch ObjectCatch;
    private int amoutOfLifes = 3;

    public void resetLife()
    {
        for (int i = 0; i < lifes.Length; i++)
        {
            lifes[i].SetActive(true);
            ObjectCatch.eatenD = 0;
            player.transform.localScale = new Vector3(1f, 1f, 1f);
            amoutOfLifes = 3;
        }
    }
    public void removeLife(){
        amoutOfLifes--;

        lifes[amoutOfLifes].SetActive(false);

        if (!lifes[0].activeSelf)
        {
            gameToggle.isOn = false;
        }

    }

}
