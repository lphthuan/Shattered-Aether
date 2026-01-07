using UnityEngine;
using Cinemachine;
using StarterAssets;

public class ThirdPersonShooterController : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera aimVirtualCamera;
	[SerializeField] private float normalSensitivity = 1f;
	[SerializeField] private float aimSensitivity = 0.5f;

	private StarterAssetsInputs starterAssetsInputs;
	private ThirdPersonController thirdPersonController;

	private void Awake()
	{
		starterAssetsInputs = GetComponent<StarterAssetsInputs>();
		thirdPersonController = GetComponent<ThirdPersonController>();
	}

	private void Update()
	{
		if (starterAssetsInputs.aim)
		{
			aimVirtualCamera.gameObject.SetActive(true);
			thirdPersonController.SetSensitivity(aimSensitivity);
		}
		else
		{
			aimVirtualCamera.gameObject.SetActive(false);
			thirdPersonController.SetSensitivity(normalSensitivity);
		}
	}
}
