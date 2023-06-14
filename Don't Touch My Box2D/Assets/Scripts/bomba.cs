using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomba : MonoBehaviour
{
    float darbeGucu;
    [SerializeField] GameObject topYokolmaefekt;
    [SerializeField] AudioSource yokOlmasesi;
    [SerializeField] GameObject gameKontrol;

    ortadaki_kutu ortadaki_kutularin_yönetimi;

    void Start()
    {
        darbeGucu = 20f;
        gameKontrol = GameObject.FindWithTag("GameKontrol");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("DigerKutular"))
        {
            collision.gameObject.GetComponent<ortadaki_kutu>().DarbeAl(darbeGucu);

            gameKontrol.GetComponent<GameKontrol>().Ses_ve_Efekt_Olustur(1,collision.gameObject);

            Destroy(gameObject);
            
        }

        if (collision.gameObject.CompareTag("Oyuncu2Kule"))
        {

            gameKontrol.GetComponent<GameKontrol>().Ses_ve_Efekt_Olustur(1, collision.gameObject);
            gameKontrol.GetComponent<GameKontrol>().Darbe_vur(2,darbeGucu);

            Destroy(gameObject);
           
        }

        if (collision.gameObject.CompareTag("Oyuncu1Kule"))
        {

            gameKontrol.GetComponent<GameKontrol>().Ses_ve_Efekt_Olustur(1, collision.gameObject);
            gameKontrol.GetComponent<GameKontrol>().Darbe_vur(1, darbeGucu);

            Destroy(gameObject);

        }
    }

    void Update()
    {
        
    }
}
