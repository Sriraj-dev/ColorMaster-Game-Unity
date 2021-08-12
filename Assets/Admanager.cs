using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;

public class Admanager : MonoBehaviour, IUnityAdsListener
{
    private string playstoreid = "4131013";
    private string appstoreid = "4131012";
    private string interstitialad = "Rewarded_Android";
    //  private string interstitialvideoad = "rewardedVideo";
    public bool istargetplaystore;
    public bool istestad;


    private void Start()
    {
        Advertisement.AddListener(this);
        InitializeAdvertisement();


        //Invoke("playinterstitialad", 5);

    }
    public void Update()
    {
        
    }
    private void InitializeAdvertisement()
    {
        if (istargetplaystore)
        {
            Advertisement.Initialize(playstoreid, istestad);
            return;
        }
        Advertisement.Initialize(appstoreid, istestad);

    }
    public void playinterstitialad()
    {
        Debug.Log(" ad started");
        if (!Advertisement.IsReady(interstitialad)) { Debug.Log("not ready "); return; }
       
        Advertisement.Show(interstitialad);
        Debug.Log(" function completed");
    }

    public void OnUnityAdsReady(string placementId)
    {
        // Debug.Log(" ad ready function");
        //Advertisement.Initialize(playstoreid, istestad);
        // throw new System.NotImplementedException();
    }

    public void OnUnityAdsDidError(string message)
    {
        //throw new System.NotImplementedException();
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        //throw new System.NotImplementedException();
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        //throw new System.NotImplementedException();
    }
}

