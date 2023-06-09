using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ortadaki_kutu : MonoBehaviour
{
    float saglik = 100;
    [SerializeField] Image healthBar;
    [SerializeField] GameObject saglikCanvasi;

    GameObject gameKontrol;

    private void Start()
    {
        gameKontrol = GameObject.FindWithTag("GameKontrol");
    }

    public void DarbeAl(float darbegucu)
    {
        saglik = saglik - darbegucu;
        healthBar.fillAmount = saglik / 100; //0.9

        if (saglik<0)
        {
            gameKontrol.GetComponent<GameKontrol>().Ses_ve_Efekt_Olustur(2,gameObject);
            Destroy(gameObject);
        }
        else
        {
            StartCoroutine(CanvasCikar());
        }

        
    }

    IEnumerator CanvasCikar()
    {
        if (!saglikCanvasi.activeInHierarchy)
        {
            saglikCanvasi.SetActive(true);
            yield return new WaitForSeconds(2);
            saglikCanvasi.SetActive(false);
        }
    }
}
