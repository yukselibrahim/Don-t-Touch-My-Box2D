using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomba : MonoBehaviour
{
    float darbeGucu;
    [SerializeField] GameObject topYokolmaefekt;
    [SerializeField] AudioSource yokOlmasesi;
    [SerializeField] GameObject gameKontrol;
    [SerializeField] GameObject Oyuncu;


    ortadaki_kutu ortadaki_kutularin_yönetimi;

    void Start()
    {
        darbeGucu = 20f;
        gameKontrol = GameObject.FindWithTag("GameKontrol");
        Oyuncu = GameObject.FindWithTag("Oyuncu1");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("DigerKutular"))
        {
            collision.gameObject.GetComponent<ortadaki_kutu>().DarbeAl(darbeGucu);

            gameKontrol.GetComponent<GameKontrol>().Ses_ve_Efekt_Olustur(1,collision.gameObject);

            Oyuncu.GetComponent<Oyuncu>().PowerOynasin();

            Destroy(gameObject);
            
        }

        if (collision.gameObject.CompareTag("Oyuncu2Kule") || collision.gameObject.CompareTag("Oyuncu2"))
        {

            gameKontrol.GetComponent<GameKontrol>().Ses_ve_Efekt_Olustur(1, collision.gameObject);
            gameKontrol.GetComponent<GameKontrol>().Darbe_vur(2,darbeGucu);
            Oyuncu.GetComponent<Oyuncu>().PowerOynasin();
            Destroy(gameObject);
           
        }

        if (collision.gameObject.CompareTag("Oyuncu1Kule") || collision.gameObject.CompareTag("Oyuncu1"))
        {

            gameKontrol.GetComponent<GameKontrol>().Ses_ve_Efekt_Olustur(1, collision.gameObject);
            gameKontrol.GetComponent<GameKontrol>().Darbe_vur(1, darbeGucu);
            Oyuncu.GetComponent<Oyuncu>().PowerOynasin();
            Destroy(gameObject);

        }

        if (collision.gameObject.CompareTag("Zemin"))
        {

            gameKontrol.GetComponent<GameKontrol>().Ses_ve_Efekt_Olustur(1, collision.gameObject);
            Oyuncu.GetComponent<Oyuncu>().PowerOynasin();
            Destroy(gameObject);

        }
    }

    void Update()
    {
        
    }
}
