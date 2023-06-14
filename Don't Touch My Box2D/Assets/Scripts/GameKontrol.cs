using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameKontrol : MonoBehaviour
{   
    [Header("TOP(BOMBA) AYARLARI VE ÝÞLEMLERÝ")]
    [SerializeField] GameObject topYokolmaefekt;
    [SerializeField] AudioSource yokOlmasesi;

    [Header("ORTADAKÝ KUTULARIN AYARLARI VE ÝÞLEMLERÝ")]
    [SerializeField] GameObject KutuYokOlmaEfekt;
    [SerializeField] AudioSource KutuYokOlmaSesi;

    [Header("OYUNCU SAÐLIK AYARLARI")]
    [SerializeField] Image Oyuncu_1_saglik_Bar;
    [SerializeField] float Oyuncu_1_saglik=100;
    [SerializeField] Image Oyuncu_2_saglik_Bar;
    [SerializeField] float Oyuncu_2_saglik = 100;

    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    public void Ses_ve_Efekt_Olustur(int kriter, GameObject objetransformu)
    {
        switch (kriter)
        {
            case 1:
                Instantiate(topYokolmaefekt, objetransformu.gameObject.transform.position, objetransformu.gameObject.transform.rotation);

                yokOlmasesi.Play();
                break;

            case 2:
                Instantiate(KutuYokOlmaEfekt, objetransformu.gameObject.transform.position, objetransformu.gameObject.transform.rotation);

                KutuYokOlmaSesi.Play();
                break;
        }
        
        
    }

    public void Darbe_vur(int kriter,float darbegucu)
    {
        switch (kriter)
        {
            case 1:
                Oyuncu_1_saglik = Oyuncu_1_saglik - darbegucu;
                Oyuncu_1_saglik_Bar.fillAmount = Oyuncu_1_saglik / 100; //0.9

                if (Oyuncu_1_saglik<=0)
                {
                    Debug.Log("Oyuncu 1 yenildi.");
                }
                break;

            case 2:
                Oyuncu_2_saglik = Oyuncu_2_saglik - darbegucu;
                Oyuncu_2_saglik_Bar.fillAmount = Oyuncu_2_saglik / 100; //0.9

                if (Oyuncu_2_saglik <= 0)
                {
                    Debug.Log("Oyuncu 2 yenildi.");
                }
                break;
        }


    }


}
