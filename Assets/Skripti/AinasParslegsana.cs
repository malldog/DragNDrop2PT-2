using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class AinasParslegsana : MonoBehaviour {

    public void UzSakumu()
    {
        SceneManager.LoadScene("SakumaAina", LoadSceneMode.Single);
    }
    public void Apturet()
    {
        Application.Quit();
    }
    public void UzMain()
    {
        SceneManager.LoadScene("PilsetasAina", LoadSceneMode.Single);
    }
    }

