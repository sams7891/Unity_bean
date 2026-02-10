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
    [Header("Ielikt tv ainas objektus tādā secībā kas atbilst backgroundiem")]
    public GameObject[] tvAssets;

    private Image toDisplay;
    private int channelInt = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int i = 0; i < tvAssets.Length; i++)
            tvAssets[i].SetActive(false);

        toDisplay = display.GetComponent<Image>();
        toDisplay.color = Color.black;
    }

    public void TurnOff()
    {
        if(toggle.isOn) {
            tvAssets[channelInt].SetActive(true);
            toDisplay.color = Color.white;
            toDisplay.sprite = background[channelInt];
        }
        else {
            toDisplay.color = Color.black;
        }
        
    }

    public void ChangeChannel(int changeBy)
    {
        if (!toggle.isOn)
            return;

        int previousChannel = channelInt;

        channelInt += changeBy;

        if (channelInt < 0)
            channelInt = background.Length - 1;
        else if (channelInt >= background.Length)
            channelInt = 0;

        toDisplay.sprite = background[channelInt];

        tvAssets[previousChannel].SetActive(false);
        tvAssets[channelInt].SetActive(true);
    }



}
