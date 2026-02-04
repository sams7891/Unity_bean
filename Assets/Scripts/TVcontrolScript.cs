using UnityEngine;
using UnityEngine.UI;

public class TVcontrolScript : MonoBehaviour
{
    public Toggle toggle;
    public GameObject display;
    public Button changeChannelForward;
    public Button changeChannelReverse;
    public Sprite[] background;
    private Image toDisplay;
    private int channelInt = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        toDisplay = display.GetComponent<Image>();
        toDisplay.color = Color.black;
    }

    public void TurnOff()
    {
        if(toggle.isOn) {
            toDisplay.color = Color.white;
            toDisplay.sprite = background[channelInt];
        }
        else {
            toDisplay.color = Color.black;
        }
        
    }

    public void ChangeChannel(int changeBy) {

        if(!toggle.isOn)
            return;

        channelInt += changeBy;

        if (channelInt < 0)
            channelInt = background.Length - 1;
        else if (channelInt >= background.Length)
            channelInt = 0;

        toDisplay.sprite = background[channelInt];
    }

    
}
