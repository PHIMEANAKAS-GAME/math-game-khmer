using UnityEngine;
using UnityEngine.UI;

public class HLVideoRewardTest : MonoBehaviour
{
    [SerializeField]
    private Button btAds;
    [SerializeField]
    private Text lblReward;
    [SerializeField]
    private Image imgVideo;

	private HLIronSourceVideoRequestService admobMediatorVideo;
    private bool isAds;
    private bool isReward;

	private void OnEnable()
    {
        HLIronSourceAdapter.OnVideoLoad += OnVideoLoaded;
        HLIronSourceListener.OnVideoComplete += OnVideoComplete;
        HLIronSourceListener.OnVideoFailed += OnVideoFailed;
    }

	private void OnDisable()
	{
		HLIronSourceAdapter.OnVideoLoad -= OnVideoLoaded;
        HLIronSourceListener.OnVideoComplete -= OnVideoComplete;
        HLIronSourceListener.OnVideoFailed -= OnVideoFailed;
    }

    private void Start()
    {
        admobMediatorVideo = GameObject.FindObjectOfType<HLIronSourceVideoRequestService>();
    }

    private void OnVideoLoaded(bool isLoad)
	{
        isAds = isLoad;
        RefreshAdsStatus();
	}

    private void OnVideoComplete()
    {
        lblReward.text = "Reward 1";
        isReward = true;
        RefreshAdsStatus();
    }

    private void OnVideoFailed()
    {
        lblReward.text = "Failed Reward";
        RefreshAdsStatus();
    }

    public void DoPlayAds()
    {
        isAds = admobMediatorVideo.isVideoReward;
        if (isAds)
        {
            isAds = false;
            lblReward.text = "";
            admobMediatorVideo.ShowRewardedVideoAds();
        }
        RefreshAdsStatus();
    }

    private void RefreshAdsStatus()
    {
        if (isReward)
        {
            imgVideo.gameObject.SetActive(false);
            btAds.interactable = false;
        }
        else
        {
            btAds.interactable = isAds;
            imgVideo.gameObject.SetActive(true);
            imgVideo.color = isAds ? Color.green : Color.gray;
        }
    }
}
