using UnityEngine;
using UnityEngine.Analytics;
using System.Collections;
using System.Collections.Generic;

public class AnalyticsManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Analytics.CustomEvent("game-start", new Dictionary<string, object> {
            {"username", "frank-n-beans"},
            {"level", "main title"},
            {"reason", "analytics on-boarding"}
        });

        ReportLevelUp();
        ReportPurchase();
        ReportUserDemographic();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ReportLevelUp()
    {
        Analytics.CustomEvent("player-level-up", new Dictionary<string, object> {
            {"username", "frank-n-beans"},
            {"character", "aloy"},
            {"new-level", 2}
        });
    }

    public void ReportPurchase()
    {
        Analytics.Transaction("deadbeef", 15.99m, "USD", null, null);
    }

    public void ReportUserDemographic()
    {
        Analytics.SetUserGender(Gender.Male);
        Analytics.SetUserBirthYear(1992);
    }
}
