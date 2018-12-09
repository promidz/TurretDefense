
using UnityEngine;

public class Shop : MonoBehaviour {

    public TurretBluePrint standardTurret;
    public TurretBluePrint missleLauncher;
    public TurretBluePrint laserBeamer;

    BuildManager buildManager;
    void Start()
    {
        buildManager = BuildManager.instance;
    }

	public void SelectStandardTurret()
    {
        Debug.Log("Standard Turret Selected");
        buildManager.SelectTurretToBuild(standardTurret);
    }
    public void SelectMissleLauncher()
    {
        Debug.Log(" Missle Launcher Selected");
        buildManager.SelectTurretToBuild(missleLauncher);
    }
    public void SelectLaserBeamer()
    {
        Debug.Log(" Laser Beamer Selected");
        buildManager.SelectTurretToBuild(laserBeamer);
    }
}
