using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AndroidBridge;
public class RewardAd : MonoBehaviour
{
    public System.Action<bool> RewardGet;
    public System.Action RewardClose;
    public void Reward()
    {
        Debug.Log("In Reward()");

        bool isSuccess = false;
        //Bridge.advertisement.ShowRewarded(success =>
        //{
        //    if (success)
        //    {
        //        // Success
        //        Debug.Log("Bridge.advertisement.ShowRewarded success: " + success);
        //        isSuccess = true;
        //    }
        //    else
        //    {
        //        // Error
        //        Debug.Log("Bridge.advertisement.ShowRewarded success: " + success);
        //    }
        //});

        //Bridge.advertisement.interstitialStateChanged += state => { Debug.Log($"Interstitial state: {state}"); };
        //Bridge.advertisement.rewardedStateChanged += state =>
        //{
        //    if (state == RewardedState.Rewarded)
        //        RewardGet?.Invoke(true);
        //    else if (state == RewardedState.Closed)
        //        RewardClose?.Invoke();
        //    Debug.Log($"Rewarded state: {state}");
        //};

        //return isSuccess;
    }
}
