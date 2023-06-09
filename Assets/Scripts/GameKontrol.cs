using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameKontrol : MonoBehaviour
{   
    [Header("TOP(BOMBA) AYARLARI VE ÝÞLEMLERÝ")]
    [SerializeField] GameObject topYokolmaefekt;
    [SerializeField] AudioSource yokOlmasesi;

    [Header("ORTADAKÝ KUTULARIN AYARLARI VE ÝÞLEMLERÝ")]
    [SerializeField] GameObject KutuYokOlmaEfekt;
    [SerializeField] AudioSource KutuYokOlmaSesi;

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

    
}
