using UnityEngine;
using UnityEngine.UI;

public class TVcontrolScript : MonoBehaviour
{
    public Toggle toggle;
    public GameObject display;
    public Button changeChannelForward;
    public Button changeChannelReverse;

    [Header("TV kanālu backgroundi")]
    public Sprite[] background;

    [Header("TV ainas objekti (channel roots!)")]
    public GameObject[] tvAssets;

    private Image toDisplay;
    private int channelInt = 0;

    void Start()
    {
        DisableAllTVAssets();

        toDisplay = display.GetComponent<Image>();
        toDisplay.color = Color.black;
    }

    public void TurnOff()
    {
        if (toggle.isOn)
        {
            toDisplay.color = Color.white;
            toDisplay.sprite = background[channelInt];

            DisableAllTVAssets();
            tvAssets[channelInt].SetActive(true);
        }
        else
        {
            toDisplay.color = Color.black;
            DisableAllTVAssets();
        }
    }

    public void ChangeChannel(int changeBy)
    {
        if (!toggle.isOn)
            return;

        DisableAllTVAssets();

        channelInt += changeBy;

        if (channelInt < 0)
            channelInt = background.Length - 1;
        else if (channelInt >= background.Length)
            channelInt = 0;

        toDisplay.sprite = background[channelInt];
        tvAssets[channelInt].SetActive(true);
    }

    private void DisableAllTVAssets()
    {
        foreach (GameObject channel in tvAssets)
        {
            channel.SetActive(false);
        }
    }
}
