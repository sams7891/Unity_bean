using UnityEngine;
using UnityEngine.UI;

public class ToggleSkripts : MonoBehaviour
{
    public GameObject bean;
    public GameObject teddy;
    public GameObject car;
    public GameObject granny;
    public GameObject toggleRight;
    public GameObject toggleLeft;
    public GameObject characterImage;
    public Sprite[] characterSprites;
    public GameObject sizeSlider;
    public GameObject rotationSlider;


    public void ToggleSide()
    {
        float xAxis;

        if (toggleLeft.GetComponent<Toggle>().isOn)
        {
            xAxis = 1;
        } else
        {
            xAxis = -1;
        }


        bean.transform.localScale = new Vector2(xAxis, 1);
    }

    public void ToggleBean(bool value)
    {
        bean.SetActive(value);
        toggleLeft.GetComponent<Toggle>().interactable = value;
        toggleRight.GetComponent<Toggle>().interactable = value;
    }

    public void ToggleTeddy(bool value)
    {
        teddy.SetActive(value);
    }

    public void ToggleCar(bool value)
    {
        car.SetActive(value);
    }

    public void ToggleGranny(bool value)
    {
        granny.SetActive(value);
    }

    public void ChangeCharacterImage(int index)
    {
        characterImage.GetComponent<Image>().sprite = characterSprites[index];
    }

    public void ChangeRotation()
    {
        float rotationValue = rotationSlider.GetComponent<Slider>().value;
        characterImage.transform.localRotation = Quaternion.Euler(0, 0, 360 * rotationValue);
    }

    public void ChazngeSize()
    {
        float sizeValue = sizeSlider.GetComponent<Slider>().value;
        characterImage.transform.localScale = new Vector2(1f * sizeValue, 1f * sizeValue);
    }
}
