using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnCanvas : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject installButton;
    GameObject practicButton;
    GameObject backButton;

    GameObject headButton;
    GameObject intarfaceButton;
    GameObject materialButton;
    GameObject conteinerButton;

    void Start()
    {
        GameObject.Find("infoButton").GetComponent<Button>().onClick.AddListener(OnClickInfoButton);
        installButton = GameObject.Find("installButton");
        practicButton = GameObject.Find("practicButton");
        backButton = GameObject.Find("backButton");
        headButton = GameObject.Find("HeadButton");
        conteinerButton = GameObject.Find("ContainerButton"); 
        intarfaceButton = GameObject.Find("PanelDevButton");
        materialButton = GameObject.Find("MaterialButton");

        installButton.GetComponent<Button>().onClick.AddListener(OnClickInstallButton);
        backButton.GetComponent<Button>().onClick.AddListener(OnClickBackButton);

        installButton.SetActive(true);
        practicButton.SetActive(true);
        headButton.SetActive(false);
        intarfaceButton.SetActive(false);
        materialButton.SetActive(false);
        backButton.SetActive(false);
        conteinerButton.SetActive(false);
    }

    void OnClickInfoButton()
    {
        GameObject.Find("infoText").GetComponent<Text>().enabled = !GameObject.Find("infoText").GetComponent<Text>().enabled;
        GameObject.Find("infoImage").GetComponent<Image>().enabled = !GameObject.Find("infoImage").GetComponent<Image>().enabled;
    }

    void OnClickInstallButton()
    {
        installButton.SetActive(false);
        practicButton.SetActive(false);
        headButton.SetActive(true);
        intarfaceButton.SetActive(true);
        materialButton.SetActive(true);
        backButton.SetActive(true);
        conteinerButton.SetActive(true);
    }

    void OnClickBackButton()
    {
        installButton.SetActive(true);
        practicButton.SetActive(true);
        headButton.SetActive(false);
        intarfaceButton.SetActive(false);
        materialButton.SetActive(false);
        backButton.SetActive(false);
        conteinerButton.SetActive(false);
    }
}
