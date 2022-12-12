using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public List<GameObject> normalModel;
    public List<GameObject> blackModel;
    public int questionNum;
    public GameObject congPanel;
    public GameObject homePanel;
    public GameObject gamePanel;
    public GameObject congAudio;
    bool allinActive;
 
    void Start()
    {
        //Configuring the objects
        allinActive = true;
        gamePanel.SetActive(false);
        congAudio.SetActive(false);
        congPanel.SetActive(false);
        for (int i = 0; i < blackModel.Count; i++)
        {
            blackModel[i].SetActive(false);
           
        }
        ChooseQuestion();
    }

    void Update()
    {
        isTrue();
        foreach (GameObject normalmodel in normalModel)
        {
            if (normalmodel.activeInHierarchy == true)
            {
                allinActive = true;
            
            }
            else
            {
                allinActive = false;
            }
        }
        if(allinActive == false)
        {
          
            gamePanel.SetActive(false);
            homePanel.SetActive(true);
        }

    }

    public void ChooseQuestion()
    {
        //Randomly choosing model
        questionNum = Random.Range(0, blackModel.Count);
        blackModel[questionNum].SetActive(true);
        StartCoroutine(ExampleCoroutine());
        
    }

    public void isTrue()
    {
        //Calculating distance and if distance less 50 doing modifications
        if (Vector2.Distance(blackModel[questionNum].transform.position, normalModel[questionNum].transform.position) < 50)
        {
            normalModel[questionNum].transform.position = blackModel[questionNum].transform.position;
            congAudio.SetActive(true);
            congPanel.SetActive(true);
            blackModel[questionNum].SetActive(false);
            normalModel[questionNum].SetActive(false);
            ChooseQuestion();
          
        }
   
    }
    IEnumerator ExampleCoroutine()
    {
        //Congrate 
        yield return new WaitForSeconds(1);
        congPanel.SetActive(false);
        congAudio.SetActive(false);
    }


}
