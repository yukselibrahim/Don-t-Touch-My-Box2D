using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Oyuncu : MonoBehaviour
{

    [SerializeField] GameObject bomba;
    [SerializeField] GameObject bombaCikisnoktasi;
    [SerializeField] ParticleSystem topAtisefekt;
    [SerializeField] AudioSource topAtmasesi;

    [SerializeField] Image Powerbar;
    float powerSayi;
    bool sonageldimi = false;

    Coroutine powerDongu;
   
    void Start()
    {
        powerDongu = StartCoroutine(PowerbarCalistir());
    }

    IEnumerator PowerbarCalistir()
    {
        Powerbar.fillAmount = 0;
        sonageldimi = false;

        while (true )
        {
            if (Powerbar.fillAmount<1 && !sonageldimi)
            {
                powerSayi = 0.01f;
                Powerbar.fillAmount += powerSayi;
                yield return new WaitForSeconds(0.0001f* Time.deltaTime);

            }
            else
            {
                sonageldimi = true;
                powerSayi = 0.01f;
                Powerbar.fillAmount -= powerSayi;
                yield return new WaitForSeconds(0.0001f * Time.deltaTime);

                if (Powerbar.fillAmount ==0)
                {
                    sonageldimi = false;
                }
            }
        }
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bombaObjem = Instantiate(bomba, bombaCikisnoktasi.transform.position,bombaCikisnoktasi.transform.rotation);
            Rigidbody2D rg = bombaObjem.GetComponent<Rigidbody2D>();
            rg.AddForce(new Vector2(2f, 0f) * Powerbar.fillAmount* 12f, ForceMode2D.Impulse);

            //Powerbar.fillAmount 1 * 12 // 0.5 * 12 = 6
            StopCoroutine(powerDongu);
            topAtisefekt.Play(); //Yukarýda particlesystem olarak tanýmladýðýmýz için topAtisefekt i play getirip oynatabiliyoruz. 

            Instantiate(topAtisefekt, bombaCikisnoktasi.transform.position, bombaCikisnoktasi.transform.rotation); //Burada bomba çýkýþ noktasýna patlama efektini instantiate ettik.
            topAtmasesi.Play();
        }

        //if (Input.GetKeyDown(KeyCode.E))
        //{
        //    PowerOynasinmi = false;
        //    Debug.Log("Gelen deðer: " + Powerbar.fillAmount);
        //}

        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    PowerOynasinmi = true;
        //    StartCoroutine(PowerbarCalistir());
        //}
    }

    public void PowerOynasin()
    {

        powerDongu = StartCoroutine(PowerbarCalistir());
    }
}
