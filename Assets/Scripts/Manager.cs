using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Manager : MonoBehaviour
{
    public GameObject[] normalModel;
    public GameObject[] siyahModel;
    public int soruNum;
    public GameObject TebrikPanel;
    public string UIScene;
    public GameObject TebrikSes;
 
    void Start()
    {
        //Gözükmemesi gerekenleri ayarlýyoruz
        TebrikSes.SetActive(false);
        TebrikPanel.SetActive(false);
        for (int i = 0; i < siyahModel.Length; i++)
        {
            siyahModel[i].SetActive(false);
           
        }
        SoruSec();
    }

    // Update is called once per frame
    void Update()
    {
        Dogrumu();
   
        if(normalModel[0].activeInHierarchy==false && normalModel[1].activeInHierarchy == false && normalModel[2].activeInHierarchy == false && normalModel[3].activeInHierarchy == false && normalModel[4].activeInHierarchy == false)
        {
            TebrikSes.SetActive(true);
            TebrikPanel.SetActive(true);
            SceneManager.LoadScene(UIScene);
        }
        
        

    }

    public void SoruSec()
    {
        //Random olarak þekilimizi seçiyoruz
        soruNum = Random.Range(0, siyahModel.Length);
        siyahModel[soruNum].SetActive(true);
        StartCoroutine(ExampleCoroutine());
        
    }

    public void Dogrumu()
    {
        //Eðer belli bir mesafeye kadar sürüklendiyse tebrik durumlarýný çalýþtýrýyor diðer soruya geçiyoruz
        if (Vector2.Distance(siyahModel[soruNum].transform.position, normalModel[soruNum].transform.position) < 50)
        {
            normalModel[soruNum].transform.position = siyahModel[soruNum].transform.position;
            TebrikSes.SetActive(true);
            TebrikPanel.SetActive(true);
            siyahModel[soruNum].SetActive(false);
            normalModel[soruNum].SetActive(false);
            SoruSec();
          
        }
   
    }
    IEnumerator ExampleCoroutine()
    {
        //Tebrik durumlarýnýn çalýþmasý için bir süre bekletiyoruzS
        yield return new WaitForSeconds(1);
        TebrikPanel.SetActive(false);
        TebrikSes.SetActive(false);
    }


}
