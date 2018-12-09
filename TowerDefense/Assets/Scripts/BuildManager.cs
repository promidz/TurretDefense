using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour {

    //singleton to make sure there is only 1 manager
    public static BuildManager instance;

    void Awake()
    {
        if(instance != null)
        {
            Debug.LogError("more than one BuildManager in scene !");
            return;
        }
        instance = this;

    }


    public GameObject buildEffect;
    public GameObject sellEffect;
    public GameObject nodeUi;

    private TurretBluePrint turretToBuild;
    private Node selectedNode;

    public NodeUI nodeUI;

    public bool CanBuild { get { return turretToBuild != null; } }
    public bool HasMoney { get { return PlayerStats.Money >= turretToBuild.cost; } }



    public void SelectNode(Node node)
    {
        nodeUi.SetActive(true);
        if(selectedNode == node)
        {
            DeselectNode();
            return;
        }
        selectedNode = node;
        turretToBuild = null;

        nodeUI.SetTarget(node);
    }

    public void DeselectNode()
    {
        selectedNode = null;
        nodeUI.Hide();
    }

    public void SelectTurretToBuild(TurretBluePrint turret)
    {
        turretToBuild = turret;
        DeselectNode();

    }
    public TurretBluePrint GetTurretToBuild()
    {
        return turretToBuild;
    }

}
