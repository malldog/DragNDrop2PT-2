using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class NomesanasVieta : MonoBehaviour, IDropHandler  {
	private float vietasZRot, velkObjZRot, rotacijasStarpiba;
	private Vector2 vietasIzm, velkObjIzm;
	private float xIzmeruStarp, yIzmeruStarp;
	public Objekti objektuSkripts;

    public void OnDrop(PointerEventData eventData)
    {
        if(eventData.pointerDrag != null) {
            if (eventData.pointerDrag.tag.Equals(tag)) {
                vietasZRot =
                GetComponent<RectTransform>().transform.eulerAngles.z;

                velkObjZRot =
                eventData.pointerDrag.GetComponent<RectTransform>().
                transform.eulerAngles.z;

                rotacijasStarpiba = Mathf.Abs(velkObjZRot - vietasZRot);

                velkObjIzm = eventData.pointerDrag.
                    GetComponent<RectTransform>().localScale;
               
                vietasIzm = GetComponent<RectTransform>().localScale;

                xIzmeruStarp = Mathf.Abs(velkObjIzm.x - vietasIzm.x);
                yIzmeruStarp = Mathf.Abs(velkObjIzm.y - vietasIzm.y);

                if ((rotacijasStarpiba <= 6 || 
                    (rotacijasStarpiba >= 354 && rotacijasStarpiba<=360))
                    && (xIzmeruStarp<= 0.1 && yIzmeruStarp <=0.1)) {
                    
                    objektuSkripts.vaiIstajaVieta = true;
                    objektuSkripts.score += 1;
                    eventData.pointerDrag.GetComponent<RectTransform>()
                        .anchoredPosition =
                        GetComponent<RectTransform>().anchoredPosition;

                    eventData.pointerDrag.GetComponent<RectTransform>()
                        .localRotation = 
                        GetComponent<RectTransform>().localRotation;

                    eventData.pointerDrag.GetComponent<RectTransform>()
                        .localScale = 
                        GetComponent<RectTransform>().localScale;


                    switch(eventData.pointerDrag.tag)
                    {
                        case "atkritumi":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[0]);
                            break;
                        case "medicina":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[1]);
                            break;
                        case "buss":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[2]);
                            break;
                        case "b2":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[2]);
                            break;
                        case "e46":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[3]);
                            break;
                        case "e61":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[3]);
                            break;
                        case "cementa":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[6]);
                            break;
                        case "ekskavators":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[7]);
                            break;
                        case "policija":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[4]);
                            break;
                        case "traktors1":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[5]);
                            break;
                        case "traktors5":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[8]);
                            break;
                        case "ugunsdzesejs":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[9]);
                            break;
                    }
                }
               
            } else {
                objektuSkripts.vaiIstajaVieta = false;
                objektuSkripts.audioAvots.
                 PlayOneShot(objektuSkripts.skanasKoAtskanot[0]);
                
                switch (eventData.pointerDrag.tag){
                    case "atkritumi":
                        objektuSkripts.atkritumuMasina.
                        GetComponent<RectTransform>().localPosition =
                        objektuSkripts.atkrMKoord;
                        break;

                    case "medicina":
                        objektuSkripts.atraPalidziba.
                        GetComponent<RectTransform>().localPosition =
                        objektuSkripts.atraPKoord;
                        break;

                    case "buss":
                        objektuSkripts.autobuss.
                        GetComponent<RectTransform>().localPosition =
                        objektuSkripts.bussKoord;
                        break;
                    case "b2":
                        objektuSkripts.b2.GetComponent<RectTransform>().localPosition = objektuSkripts.b2Koord; break;
                    case "e46":
                        objektuSkripts.e46.GetComponent<RectTransform>().localPosition = objektuSkripts.e46Koord; break;
                    case "e61":
                        objektuSkripts.e61.GetComponent<RectTransform>().localPosition = objektuSkripts.e61Koord; break;
                    case "ekskavators":
                        objektuSkripts.ekskavators.GetComponent<RectTransform>().localPosition = objektuSkripts.ekskavatorsKoord; break;
                    case "policija": 
                        objektuSkripts.policija.GetComponent<RectTransform>().localPosition = objektuSkripts.policijaKoord; break;
                    case "traktors1": 
                        objektuSkripts.traktors1.GetComponent<RectTransform>().localPosition = objektuSkripts.traktors1Koord; break;
                    case "traktors5":
                        objektuSkripts.traktors5.GetComponent<RectTransform>().localPosition = objektuSkripts.traktors5Koord; break;
                    case "ugunsdzesejs":
                        objektuSkripts.ugunsdzesejs.GetComponent<RectTransform>().localPosition = objektuSkripts.ugunsdzesejsKoord; break;
                }
            }
        }
        if (objektuSkripts.score == 12) {
            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[10]);
            objektuSkripts.scoreBoard.SetActive(true);
            objektuSkripts.star1spot.SetActive(true);
            objektuSkripts.star2spot.SetActive(true);
            objektuSkripts.star3spot.SetActive(true);
            objektuSkripts.restartButton.SetActive(true);
        }
    }
}
