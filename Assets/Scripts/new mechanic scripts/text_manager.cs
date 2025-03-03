using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class text_manager : MonoBehaviour
{
    public TextMeshProUGUI TextNitro;
    public TextMeshProUGUI TextRings;
    public Booster boost;
    public CollectableSpawner CS;

    private void Update()
    {
        TextNitro.text = "Fuel : " + boost.Nitro.ToString();
        TextRings.text = "Score : " + CS.Score.ToString();

       if (boost.Nitro <= 0f)
       {
            SceneManager.LoadScene("GameMode");
       }
    }






}
